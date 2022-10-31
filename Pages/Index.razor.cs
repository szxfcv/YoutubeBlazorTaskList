namespace YoutubeBlazorTaskList.Pages
{
    public partial class Index
    {
        readonly string[] addTaskCommands = new string[6]{ "!taska ", "!taskadd ", "!atask ", "!addtask ", "!task ", "!add " };
        // Delete task commands
        readonly string[] deleteTaskCommands = new string[10] { "!taskdel ", "!taskdelete ", "!deltask ", "!deletetask ", "!taskr ", "!taskremove ", "!rtask ", "!removetask ", "!remove ", "!delete " };

        // Edit task commands
        readonly string[] editTaskCommands = new string[5] { "!taske ", "!taskedit ", "!etask ", "!edittask ", "!edit " };

        // Finish task commands
        readonly string[] finishTaskCommands = new string[11] { "!taskf ", "!taskfinish ", "!ftask ", "!finishtask ", "!taskd ", "!taskdone ", "!donetask ", "!dtask ", "!finish ", "!done ", "!finished " };
    }
}
