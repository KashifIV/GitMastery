public class Source : Node{
    string filename, filetype;
    
    public Source(string fileName, string fileType) {
        filename = fileName; 
        filetype = fileType; 
    }
    public string FileName{
        get=> filename; 
    }
    public string FileType {
        get=> filetype; 
    }

}