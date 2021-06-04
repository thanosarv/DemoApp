using DemoApp.DAL;
using System;

namespace DemoApp.BAL.Repository
{
    public abstract class Repository : IDisposable
    {
        private readonly DemoAppContext _context;
        private readonly bool _ownsContext;

        protected DemoAppContext Context => _context;

        public Repository() : this(new DemoAppContext(), true)
        {
        }

        public Repository(DemoAppContext context, bool ownsContext = false)
        {
            _context = context;
            _ownsContext = ownsContext;
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_ownsContext)
                    _context?.Dispose();
            }
        }
    }
}