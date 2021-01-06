namespace systemControlLyar.functionInterface
{
    public interface IClassFunctions
    {
        public bool AddClass(ClassEntity classEntity);
        public bool DeleteClassById(int id);
        public ClassEntity SelectClass(int id);
    }
}