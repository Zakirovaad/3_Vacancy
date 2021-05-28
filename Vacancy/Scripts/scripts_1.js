var search_vac = {
    id: 0,
    id_hh:0,
    name: "",
    salary: 0,
    organization: "",
    contact_person: "",
    phone_number: "",
    empl_type: "",
    description: ""
};

var global_vac = {
    id: 0,
    id_hh: 0,
    name: "",
    salary: 0,
    organization: "",
    contact_person: "",
    phone_number: "",
    empl_type: "",
    description: ""
};

var dis_but = 1;

function ParseVacancy(list) {
    var vac = {
        id: 0,
        id_hh: 0,
        name: "",
        salary: 0,
        organization: "",
        contact_person: "",
        phone_number: "",
        empl_type: "",
        description: ""
    };
    if (list != null) {
        vac.id = list.id;
        vac.id_hh = list.id;

        if (list.name != null) {
            vac.name = list.name;
        }
        if (list.salary != null) {
            if (list.salary.from!=null) {
                vac.salary = list.salary.from;
            }
            else vac.salary = list.salary.to;
            
        }
        if (list.employer != null) {
            vac.organization = list.employer.name;
            vac.contact_person = list.employer.name;

        }
        if (list.contacts != null) {
            vac.phone_number = list.contacts;
        }
        if (list.employment != null) {
            vac.empl_type = list.employment.name;
        }
        if (list.description != null) {
            vac.description = list.description;
        }

  
    }
    return vac;
}