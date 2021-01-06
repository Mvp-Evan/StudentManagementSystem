namespace systemControlLyar.functionInterface
{
    public class ClassFunctions : IClassFunctions
    {
        public bool AddClass(ClassEntity classEntity)
        {
            using (var db = new EntityContext())
            {
                db.Add(classEntity);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteClassById(int id)
        {
            using (var db = new EntityContext())
            {
                ClassEntity classEntity = db.classes.Find(id);
                db.Remove(classEntity);
                db.SaveChanges();
                return true;
            }
        }

        public ClassEntity SelectClass(int id)
        {
            ClassEntity classEntity;
            using (var db = new EntityContext())
            {
                classEntity = db.classes.Find(id);
            }

            return classEntity;
        }
    }
}