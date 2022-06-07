import { environment } from 'src/environments/environment';

export namespace ApiRoutes {
    
    export class AdminIdentityRoutes {
        public static REGISTER = `${environment.api}/Identity/register`;
        public static LOGIN = `${environment.api}/Identity/login`;
    }

    export class AdminProfileRoutes {
        public static GET_BY_ID = `${environment.api}/UserProfiles/admins/`;
    }

    export class TenantProfileRoutes {
        public static GET_BY_ID = `${environment.api}/UserProfiles/tenants/`;
    }

    export class BuildingRoutes {
        public static GET_BY_ID = `${environment.api}/Buildings/`;
        public static POST = `${environment.api}/Buildings/post/`;
    }

    export class ApartmentRoutes {
        public static GET_BY_ID = `${environment.api}/Apartments/`;
        public static PUT_RESIDENTS = `${environment.api}/Apartments/id/residents`;
        public static PUT_SURFACE_AREA = `${environment.api}/Apartments/id/surface-area`;
    }

    export class InvoiceRoutes {
        public static GET_BY_ID = `${environment.api}/Invoices/`;
        public static GET_BY_APARTMENT_ID = `${environment.api}/Invoices/apartment-id`
        public static POST = `${environment.api}/Invoices`;
    }

    export class MasterUtilityRoutes {
        public static GET_BY_ID = `${environment.api}/MasterConsumableUtilities/id`;
        public static POST = `${environment.api}/MasterConsumableUtilities`;
        public static PUT_CURRENT_INDEX = `${environment.api}/MasterConsumableUtilities/update-current-month-index`;
        public static PUT_PRICE = `${environment.api}/MasterConsumableUtilities/update-price`;
    }

    export class BranchedUtilityRoutes {
        public static GET_BY_ID = `${environment.api}/BranchedConsumableUtilities/id`;
        public static PUT_CURRENT_INDEX = `${environment.api}/BranchedConsumableUtilities/current-month-index`;
        public static PUT_BRANCHED_STATUS = `${environment.api}/BranchedConsumableUtilities/branched-status`;
    }
}