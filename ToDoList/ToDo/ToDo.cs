namespace ToDo
{
  public class ToDo
  {
    static void Main(String[] args){

    }
    //  Constructor
    // Assign list of strings to taskList
    private List<string> taskList;
  
    public ToDo(){
      taskList = new List<string>{};
    }

    public List<string> getTaskList
    {
      get => taskList;
    }

    public string getCurrentTask()
    {
      string currentTask = taskList.First();
      return currentTask;
    }
  }
}

// List<string> myList = new List<string>()