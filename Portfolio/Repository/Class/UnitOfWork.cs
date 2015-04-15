using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Class
{
    public class UnitOfWork : IDisposable
    {
        #region PrivateProperies
        private evertonrafael_testEntities context = new evertonrafael_testEntities();
        private GenericRepository<Usuario> usuarioRepository;
        #endregion

        #region PublicProperties
        public GenericRepository<Usuario> UsuarioRepository
        {
            get
            {

                if (this.usuarioRepository == null)
                {
                    this.usuarioRepository = new GenericRepository<Usuario>(context);
                }
                return usuarioRepository;
            }
        }
        #endregion

        #region Methods
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
