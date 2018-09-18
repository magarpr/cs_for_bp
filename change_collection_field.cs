// Define Values for debugging only
DataTable old_collection = new DataTable();
dt.Columns.Add("Field (Text)", typeof(string));
dt.Columns.Add("Value (Text)", typeof(string));

String old_value = "Site as it appears in the EDC System (please separate each site with a comma):";
String new_value = "Site # as it appears in the EDC System (please separate each site # with a comma):";



DataTable new_collection = old_collection;

// 