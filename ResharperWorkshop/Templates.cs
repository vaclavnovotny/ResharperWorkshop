namespace ResharperWorkshop;

public class Templates
{
    private readonly IRenameMe _renameMe;

    public Templates(IRenameMe renameMe) {
        _renameMe = renameMe;
    }

    public string MethodThrowingException() {
        // todo: ooops, this method throws exception, put it into try-catch
        var result = _renameMe.Method(string.Empty);

        //... some processing

        return result;
    }

    // todo move this method before the other method without mouse and cut/copy/paste
    public void Method2() {
        if (true) {
            if (true) {
                if (true) {

                }
            }
        }
    }
}
