using HomePage.Classes.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Entities
{
    public class Company :DbObject
    {
        public Company(string name, string address, string[] contacs, string taxNo, TaxOffice taxOffice, string ticaretSicilNo, string tcNo, CompanyTypes companyType, string[] taxTypes)
        {
            Name = name;
            Address = address;
            Contacs = contacs;
            TaxNo = taxNo;
            TaxOffice = taxOffice;
            TicaretSicilNo = ticaretSicilNo;
            TcNo = tcNo;
            CompanyType = companyType;
            TaxTypes = taxTypes;
        }
        public Company()
        {

        }
        [Custom(FieldName ="Şirket Ünvanı",MinLength = 3,MaxLength = 60)]
        public string Name { get; set; }
        [Custom(FieldName = "Şirket Adresi",MinLength = 10,MaxLength = 255)]
        public string Address { get; set; }
        public string[] Contacs { get; set; } // Contact._id
        [Custom(FieldName = "Vergi Numarası",MaxLength =10,MaxLengthMessage ="Vergi Numarası on haneden büyük olamaz",MinLength = 10,MinLengthMessage ="Vergi Numarası 10 haneden küçük olamaz",PlaceHolderText ="Vergi Numarası" )]
        public string TaxNo { get; set; } // Max= 100
        public TaxOffice TaxOffice { get; set; }
        [Custom(FieldName ="Ticaret Sicil Numarası")]
        public string TicaretSicilNo { get; set; }
        [Custom(FieldName ="Tc Kimlik Numarası",MinLength = 11,MaxLength = 11,Nullable = true)]
        public string TcNo { get; set; } // Eğer Şahıs Şirketi ise
        [Custom(FieldName ="Şirket Türü")]
        public CompanyTypes CompanyType { get; set; }
        public string[] TaxTypes { get; set; } // ????????

    }

    public class TaxOffice : DbObject
    {
        public string Name { get; set; }
    }
}
