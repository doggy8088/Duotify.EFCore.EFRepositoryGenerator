namespace Duotify.EFCore.EFRepositoryGenerator
{
    public class CommandOption
    {
        public string ValueName { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public bool IsFlag { get; set; }
    }
}