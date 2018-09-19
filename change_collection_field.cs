// Define Values for debugging only
DataTable old_collection = new DataTable();
dt.Columns.Add("Field (Text)", typeof(string));
dt.Columns.Add("Value (Text)", typeof(string));

String old_value = "Site as it appears in the EDC System (please separate each site with a comma):";
String new_value = "Site # as it appears in the EDC System (please separate each site # with a comma):";



DataTable new_collection = old_collection;

// Blue Prism Code
for (int i = 0; i < old_collection.Rows.Count; i++)
{
    for (int j = 0; j < old_collection.Columns.Count; j++)
    {
        if (old_collection.Rows[i][j] == old_value)
        {
            old_collection.Rows[i][j] = new_value;
        }
    }
}
new_collection = old_collection;