using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Classes.Database;
using HomePage.Classes.Database.Entities;
using HomePage.Classes.Database.Enums;
using HomePage.CustomControls;

namespace HomePage.Forms
{
    public partial class CreateForm : Form
    {
        private DbObject _entity;
        private FormGoal _goal;
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
            if (_goal == FormGoal.Update)
            {
                CtnData.ButtonText = "Güncelle";
                CtnData.ClickEvent = ButtonClickUpdate;
            }
            else if (_goal == FormGoal.Add)
            {
                CtnData.ButtonText = "Veri Ekle";
                CtnData.ClickEvent = ButtonClickAdd;
            }
            var size = new Size(CtnData.Size.Width+200, CtnData.Size.Height);
            this.Size = size;
            this.MaximumSize = size;
            this.MinimumSize = size;
        }

        private void ButtonClickAdd(object sender, EventArgs e)
        {
            var type = _entity.GetType();
            var genericType = typeof(CRUD<>).MakeGenericType(type);
            
            //dynamic genericCRUD = Activator.CreateInstance(genericType);
            //genericCRUD.Insert(CtnData.Object);

            var genericCRUD = Activator.CreateInstance(genericType);
            var method = genericType.GetMethod("Insert");
            var objectC = CtnData.Object;
            method?.Invoke(genericCRUD, new[] { objectC });
            if (method!=null)
            {
                Close();
            }
        }
        private void ButtonClickUpdate(object sender, EventArgs e)
        {
            var type = _entity.GetType();
            var genericType = typeof(CRUD<>).MakeGenericType(type);

            var genericCRUD = Activator.CreateInstance(genericType);
            var method = genericType.GetMethod("Update");
            var objectC = CtnData.Object;
            method?.Invoke(genericCRUD, new[] {_entity._id, objectC });
            if (method != null)
            {
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
