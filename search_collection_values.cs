int occurences = 0;
bool found_flag = false;

//Blue Prism Code
occurences = 0;
found_flag = false;

for (int i = 0; i < collection.Rows.Count; i++)
{
  for (int j = 0; j < old_collection.Columns.Count; j++)
  {
    if (collection.Rows[i][j].ToString().Trim() == search_string.Trim())
    {
      occurences++;
    }
  }
}

if (occurences > 0){found_flag=true;}
