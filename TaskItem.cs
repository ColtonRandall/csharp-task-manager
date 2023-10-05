namespace task_manager
{
	public class TaskItem
	{
        // Variables that make up a task
        private string _name;
		private DateTime _date = new DateTime();
		private bool _isCompleted;


		public TaskItem(string name, DateTime date, bool isCompleted)
		{
			_name = name;
			_date = date;
			_isCompleted = isCompleted;
		}
	}
}

