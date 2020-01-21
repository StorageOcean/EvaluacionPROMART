using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpotifyAppApiRest
{
    public partial class SpotifyAppBDContext : DbContext
    {
        public SpotifyAppBDContext()
        {
        }

        public SpotifyAppBDContext(DbContextOptions<SpotifyAppBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SpotifyPlayList> SpotifyPlayList { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6203HGC;Database=SpotifyAppBD;UID=sa;PWD=fXd2x%IVGp;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<SpotifyPlayList>(entity =>
            {
                entity.HasKey(e => e.IdList)
                    .HasName("PK__SpotifyP__143D7F070FAD99DE");

                entity.Property(e => e.IdList).HasColumnName("idList");

                entity.Property(e => e.Album)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Artista)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
