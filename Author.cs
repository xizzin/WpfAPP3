//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        public int Id_Author { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public Nullable<int> ID_Book { get; set; }
        public Nullable<int> ID_Genres { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Genres Genres { get; set; }
    }
}