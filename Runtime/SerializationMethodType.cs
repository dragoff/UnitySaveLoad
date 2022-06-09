namespace Gameframe.SaveLoad
{
    public enum SerializationMethodType
    {
        Default = 0,

        Binary = 1,
        BinaryEncrypted = 101,

        UnityJson = 2,
        UnityJsonEncrypted = 102,
        
        JsonDotNet = 3,
        JsonDotNetEncrypted = 103,
        
        Custom = 1000
    }
}