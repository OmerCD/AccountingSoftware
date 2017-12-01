﻿using HomePage.Classes.Database.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Cruds
{
    public class CompanyCRUD : CRUD<Company>
    {
        public CompanyCRUD():base(DbFactory.Company)
        {
        }

        public async Task<Dictionary<string, string>> GetCompanyNames() // PersonnelName,_id
        {
            Dictionary<string, string> companyList = new Dictionary<string, string>();
            HashSet<string> nameList = new HashSet<string>();
            nameList.Add("ALL");
            companyList.Add("ALL", "ALL"); // Tüm Personel için
            foreach (var item in await GetAll(new BsonDocument()))
            {
                if (nameList.Contains(item.Name) == false)
                {
                    companyList.Add(item.Name, item._id);
                    nameList.Add(item.Name);
                }

            }

            return companyList;
        }
    }
}
