using BS.Data.Entity.Repositories;
using BS.Domain;
using BS.Domain.Repositories;

namespace BS.Data.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private BookSwapContext context;

        public UnitOfWork(BookSwapContext dbContext)
        {
            this.context = dbContext;
            this.messageRepository = new MessageRepository(context);
            this.threadRepository  = new ThreadRepository(context);
            this.bookRepository    = new BookRepository(context);
            this.userRepository    = new UserRepository(context);
        }
        
        public IMessageRepository messageRepository { get; set; }

        public IThreadRepository threadRepository { get; set; }

        public IBookRepository bookRepository { get; set; }

        public IUserRepository userRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }

        public void SaveAsync()
        {
            context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
