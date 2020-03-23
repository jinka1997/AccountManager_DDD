using System;
using System.Collections.Generic;
using System.Text;
using AmDomain.Repositories;
using AmDomain.Models;
using System.Threading.Tasks;

namespace AmDomain.Services.Domain
{
    public class BookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Register(int userId, string name)
        {
            //登録済？
            var exists = _bookRepository.Exists(userId, name);
            if (exists)
            {
                throw new Exception("もうあるよ");
            }

            //インスタンス生成
            var book = Book.BookFactory(userId, name);

            //ソート順のセット
            var sortOrder = _bookRepository.GetNewSortOrder(book);
            book.SetSortOrder(sortOrder);

            //登録
            _bookRepository.Add(book);

            await _bookRepository.SaveChangesAsync();
        }
    }
}
