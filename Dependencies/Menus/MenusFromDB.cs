
namespace Menus
{
    public class MenusFromDB
    {

    internal static List<MenuItem> Get()
        {
            var _Menus = new List<MenuItem>(); ;

            _Menus.Add(new MenuItem { ID = 1, Title = "Home", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 2, Title = "Transactin", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 3, Title = "Depreciation", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 4, Title = "Reports", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 5, Title = "User Management", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 6, Title = "Auditing", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 7, Title = "Operation", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 8, Title = "Organization", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });
            _Menus.Add(new MenuItem { ID = 9, Title = "System", Active = true, Icon = "bi bi-house", Level = 1, ParentID = 0 });

            _Menus.Add(new MenuItem { ID = 11, Title = "Control Center", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 1 });
            _Menus.Add(new MenuItem { ID = 12, Title = "My Account", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 1 });
            _Menus.Add(new MenuItem { ID = 13, Title = "Process Management", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 1 });
            _Menus.Add(new MenuItem { ID = 14, Title = "Pending Process", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 1 });
            _Menus.Add(new MenuItem { ID = 15, Title = "My Reports", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 1 });

            _Menus.Add(new MenuItem { ID = 21, Title = "New Asset", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 22, Title = "Relocate Asset", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 23, Title = "Search", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 24, Title = "Edit Asset info", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 25, Title = "Asset Decreciation", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 26, Title = "Return Receive Asset", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 27, Title = "Box Transaction", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 28, Title = "Asset Cost Statistics", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 29, Title = "Assign Custodian", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 30, Title = "Change Custodian", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            _Menus.Add(new MenuItem { ID = 31, Title = "Custodian Statistics", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 2 });
            
            _Menus.Add(new MenuItem { ID = 32, Title = "Depreciation Period", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 3 });
            _Menus.Add(new MenuItem { ID = 33, Title = "Depreciation Calculation", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 3 });
            
            _Menus.Add(new MenuItem { ID = 41, Title = "Asset Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 42, Title = "Calss Quantity Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 43, Title = "Asset Quantity Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 44, Title = "Location Quantity Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 45, Title = "Asset Group Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 46, Title = "General Location Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            _Menus.Add(new MenuItem { ID = 47, Title = "Advance Report", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 4 });
            
            _Menus.Add(new MenuItem { ID = 51, Title = "Users Account", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 52, Title = "User Groups", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 53, Title = "User Shift", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 54, Title = "Current User Shift", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 55, Title = "System Privileges", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 56, Title = "User Location", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 57, Title = "Task Privileges", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 58, Title = "User Alarms", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            _Menus.Add(new MenuItem { ID = 59, Title = "LITE Privileges", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 5 });
            
            _Menus.Add(new MenuItem { ID = 61, Title = "Auditing Cycle", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 6 });
            _Menus.Add(new MenuItem { ID = 62, Title = "Auditing Reports", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 6 });
            _Menus.Add(new MenuItem { ID = 63, Title = "Auditing Transactions", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 6 });
            _Menus.Add(new MenuItem { ID = 64, Title = "Auditing Statistics", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 6 });
            
            _Menus.Add(new MenuItem { ID = 71, Title = "User Logs", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 7 });
            _Menus.Add(new MenuItem { ID = 72, Title = "Emails Logs", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 7 });
            _Menus.Add(new MenuItem { ID = 73, Title = "Transactions Forms", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 7 });
            _Menus.Add(new MenuItem { ID = 74, Title = "Custom Forms", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 7 });
            _Menus.Add(new MenuItem { ID = 75, Title = "Transactions Statistics", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 7 });
            
            _Menus.Add(new MenuItem { ID = 81, Title = "Classification Tree", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 82, Title = "Classification Profile", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 83, Title = "Location Tree", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 84, Title = "Branches ", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 85, Title = "Department", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 86, Title = "Employees", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 87, Title = "Employees Signature", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            _Menus.Add(new MenuItem { ID = 88, Title = "Custom Fields", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 8 });
            
            _Menus.Add(new MenuItem { ID = 91, Title = "System License", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 9 });
            _Menus.Add(new MenuItem { ID = 92, Title = "System Softwares", Active = true, Icon = "bi bi-printer", Level = 2, ParentID = 9 });

            return _Menus;
        }
    }
}
