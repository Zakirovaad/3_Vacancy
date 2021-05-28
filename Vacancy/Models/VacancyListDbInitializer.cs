using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Vacancy.Models
{
    public class VacancyListDbInitializer : DropCreateDatabaseAlways<VacancyListContext>
    {
        protected override void Seed(VacancyListContext db)
        {
            /*db.VacancyList.Add(new VacancyList { name = "Фельдшер",salary=100000, organization = "ООО Сервисная Медицинская Компания", contact_person = "ООО Сервисная Медицинская Компания", phone_number="8894455", empl_type="Полная занятость", description= "Проведение предрейсовых и послерейсовых медосмотров водителей, оказание первой доврачебной помощи, контроль санитарного состояния на объектах. Ведение журналов, составление отчетов. Бракераж в столовых." });
            db.VacancyList.Add(new VacancyList { name = "Администратор медицинского центра", salary = 65000, organization = "ООО Ульфар", contact_person = "ООО Ульфар", phone_number = "856555", empl_type = "Полная занятость", description = "В связи с открытием в Уфе нового Медицинского центра открыт набор на вакансию: Начинающий косметолог." });
            db.VacancyList.Add(new VacancyList { name = "Фармацевт-провизор", salary = 35000, organization = "ООО Триумф Арт", contact_person = "ООО Триумф Арт", phone_number = "2244545", empl_type = "Полная занятость", description = "работа в дружном, профессиональном коллективе" });
            */
            base.Seed(db);
        }
    }
}