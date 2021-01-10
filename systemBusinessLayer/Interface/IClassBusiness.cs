namespace ClassManagementSystem.Interface
{
    public interface IClassBusiness
    {
        /**
         * @param id
         * judge class id if exists
         */
        public bool ClassIsExists(int id);

        /**
         * @param id, name
         * create new class by id, name and save this new class into database
         */
        public void CreateClass(int id, string name);

        /**
         * @param id
         * delete class by id from database
         */
        public void DeleteClass(int id);

        /**
         * @param id, newId
         * change class id to new id
         * judge the id if exists and new id if exists
         */
        public bool ChangeClassId(int id, int newId);

        /**
         * @param id, newName
         * change class name by id
         */
        public void ChangeClassName(int id, string newName);

        /**
         * @param id, newTeacherId
         * change class teacher belong
         */
        public void ChangeClassTeacherBelong(int id, int newTeacherId);
    }
}