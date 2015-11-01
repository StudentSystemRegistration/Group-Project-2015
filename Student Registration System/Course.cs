/*
Authors:    Brian Discin
            Paul Dunne
            Eddy Fakhry
            Declan Murphy
            Elvis Porebski   
Date:       31-10-15
Purpose:    Student Registration System
*/

namespace Student_Registration_System
{
    public class Course
    {
        //  Member Variables
        private string courseCode;
        private string title;
        private string level;
        private int currentStage;
        private int minPoints;

        private Stage[] stages;

        //  Custom Constructor
        public Course(string courseCode, string title, string level, int minPoints, Stage[] stages)
        {
            setCourseCode(courseCode);
            setTitle(title);
            setLevel(level);
            setCurrentStageID(0);
            setMinPoints(minPoints);
            setStages(stages);
        }

        //  Getter Methods
        public string getCourseCode()
        {
            return this.courseCode;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getLevel()
        {
            return this.level;
        }

        public int getCurrentStageID()
        {
            return this.currentStage;
        }

        public int getMinPoints()
        {
            return this.minPoints;
        }

        public Stage[] getStages()
        {
            return this.stages;
        }

        //  Setter Methods
        public void setCourseCode(string courseCode)
        {
            this.courseCode = courseCode;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setLevel(string level)
        {
            this.level = level;
        }

        public void setCurrentStageID(int currentStage)
        {
            this.currentStage = currentStage;
        }

        public void setMinPoints(int minPoints)
        {
            this.minPoints = minPoints;
        }

        public void setStages(Stage[] stages)
        {
            this.stages = stages;
        }

        public int getNextStageID()
        {
            if(stages == null)
            {
                return -1;
            }
            else if(string.Equals(stages[currentStage].getStatus(), "passed")){
                if(currentStage + 1 >= stages.Length)
                {
                    return -1;
                }
                return currentStage + 1;
            }
            return currentStage;
        }

        ////todo

        //// getStage
        //public Stage getStage(int stage)
        //{
        //    return stages[stage - 1];
        //}

        //public int getCurrStage()
        //{
        //    return currentStage;
        //}

        //public void setCurrStage(int stage)
        //{
        //    currentStage = stage;
        //}

        //public Stage getNextStage()
        //{
        //    return stages[currentStage];            
        //}
    }
}

