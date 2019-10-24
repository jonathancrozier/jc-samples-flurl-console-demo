namespace JC.Samples.FlurlConsoleDemo.Models
{
    /// <summary>
    /// Represents a 'todo' item.
    /// </summary>
    public class Todo
    {
        #region Properties

        /// <summary>
        /// The unique ID of the todo item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The ID of the user the todo item is assigned to.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The Title/Description of the todo item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Whether or not the todo item has been completed.
        /// </summary>
        public bool Completed { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Overrides the standard 'ToString' method with the title of the todo.
        /// </summary>
        /// <returns>The title of the todo with a prefix</returns>
        public override string ToString() => $"Title: {Title}";

        #endregion
    }
}