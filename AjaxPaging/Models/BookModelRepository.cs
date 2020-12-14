using System.Collections.Generic;
using AjaxPaging.Helper;

namespace AjaxPaging.Models
{
    public class BookModelRepository
    {
        public static List<BookModel> GetAll()
        {
            return new List<BookModel>()
            {
                new  BookModel() { Title="b1",Description="d1"},
                new  BookModel() { Title="b2",Description="d2"},
                new  BookModel() { Title="b3",Description="d3"},
                new  BookModel() { Title="b4",Description="d4"},
                new  BookModel() { Title="b5",Description="d5"},
                new  BookModel() { Title="b6",Description="d6"},
                new  BookModel() { Title="b7",Description="d7"}
            };
        }
    }
}
