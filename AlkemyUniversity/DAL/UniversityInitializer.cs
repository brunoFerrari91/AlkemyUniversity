using AlkemyUniversity.Models;
using System;
using System.Collections.Generic;

namespace AlkemyUniversity.DAL
{
    public class UniversityInitializer: System.Data.Entity. DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            base.Seed(context);
        }      
    }
}