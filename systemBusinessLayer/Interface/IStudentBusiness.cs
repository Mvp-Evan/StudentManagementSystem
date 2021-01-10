namespace ClassManagementSystem.Interface
{
    public interface IStudentBusiness
    {
        /**
         * @param id, name, subject, sex
         * This function interface can create a student entity and save into database by these param
         */
        public void CreateStudent(int id, string name, string subject, string sex);
        
        /**
         * @param id
         * Delete student information from database by id and check this id if exists
         */
        public bool DeleteStudentById(int id);
        
        /**
         * @param classId, studentId
         * Add student into class by add column information of student entity
         * check if classId exists and check studentId if exists
         */
        public bool AddStudentIntoClass(int classId, int studentId);

        /**
         * @param id
         * Remove student from class by set classId of student entity to 0
         * check student id if exists
         * check student if already in a class
         */
        public bool RemoveStudentFormClass(int id);

        /**
         * @param id, newId
         * change Exist student id to a new id
         * check student if exists and check new id if already used
         */
        public bool ChangeStudentId(int id, int newId);
    }
}