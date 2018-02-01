using System;
using System.Drawing;
using System.Windows.Forms;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database.Enums;
using HomePage.CustomControls;

namespace HomePage.Forms
{
    public partial class CreateForm : NoBorderForm
    {
        private DbObject _entity;
        private readonly FormGoal _goal;
        public object Entity => _entity;

        public string FormTitle
        {
            set => LabelTitle.Text = value;
        }
        public CreateForm(DbObject entity, FormGoal goal)
        {
            InitializeComponent();
            HandleCreated += CreateForm_HandleCreated;
            _entity = entity;
            _goal = goal;
        }

        private void CreateForm_HandleCreated(object sender, EventArgs e)
        {
            CtnData.Object = _entity;
            switch (_goal)
            {
                case FormGoal.Update:
                    CtnData.ButtonText = "Güncelle";
                    CtnData.ButtonClickEvent += ButtonClickUpdate;
                    Text = "Güncelleme Ekranı";
                    break;
                case FormGoal.Add:
                    CtnData.ButtonText = "Veri Ekle";
                    CtnData.ButtonClickEvent += ButtonClickAdd;
                    Text = "Yeni Kayıt Ekle";
                    break;
                case FormGoal.Delete:
                    throw new ArgumentOutOfRangeException();
                case FormGoal.None:
                    CtnData.ButtonText = "Onayla";
                    CtnData.ButtonClickEvent += ButtonAssignObjectValues;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            var size = new Size(CtnData.Size.Width, CtnData.Size.Height + CtnData.ContainerButton.Height + 80);
            this.Size = size;
            //this.MaximumSize = size;
            //this.MinimumSize = size;
        }

        private void ButtonAssignObjectValues(object sender, EventArgs e)
        {
            _entity = CtnData.Object as DbObject;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonClickAdd(object sender, EventArgs e)
        {
            var type = _entity.GetType();

            //var genericCRUD = MainPage.GetCRUD(type);
            //genericCRUD.Insert(CtnData.Object);

            var genericType = typeof(CRUD<>).MakeGenericType(type);
            var genericCRUD = Activator.CreateInstance(genericType);
            var method = genericType.GetMethod("Insert");
            var objectC = CtnData.Object;
            method?.Invoke(genericCRUD, new[] { objectC });
            if (method != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void ButtonClickUpdate(object sender, EventArgs e)
        {
            var type = _entity.GetType();
            var genericType = typeof(CRUD<>).MakeGenericType(type);

            var genericCRUD = MainPage.GetCRUD(type);
            var method = genericType.GetMethod("Update");
            var objectC = CtnData.Object;

            if (type == typeof(User))
            {
                var newUser = (User)objectC;
                if (newUser.UserType != UserTypes.Yönetici)
                {
                    if (UserCRUD.CheckIfUserLastAdmin(type, _entity._id))
                    {
                        MessageBox.Show("Son yönetici tipini değiştiremezsiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            method?.Invoke(genericCRUD, new[] { _entity._id, objectC });
            if (method != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
