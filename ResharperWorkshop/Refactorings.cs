namespace ResharperWorkshop
{
    public interface IRenameMe
    {
        string Method(string renameParameter);
        void MethodWithArguments(string par1, string par2, int par3, int par4);
        Task<string> AsyncMethod();
    }

    public class RenameMe : IRenameMe
    {
        public string Method(string renameParameter) {
            throw new Exception();
        }

        public void MethodWithArguments(string par1, string par2, int par3, int par4) {

        }

        public Task<string> AsyncMethod() => throw new NotImplementedException();

        // todo: add method and pull it up to interface
    }

    public class Usage
    {
        public void UsageMethod() {
            var renameMe = new RenameMe() as IRenameMe;
            renameMe.MethodWithArguments("1", "2", 3, 4);
        }
    }
}