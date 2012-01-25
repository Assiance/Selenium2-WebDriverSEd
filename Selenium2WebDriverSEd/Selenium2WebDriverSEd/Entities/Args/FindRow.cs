namespace WebDriverSEd.Entities.Args
{
    public class FindRow
    {
        public FindRow()
        {
        }

        public FindRow(string theKey, int theKeyColumn)
        {
            Key = theKey;
            KeyColumn = theKeyColumn;
        }

        public string Key { get; set; }
        public int KeyColumn { get; set; }
    }
}