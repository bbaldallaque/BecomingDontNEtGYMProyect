using System;
using System.ComponentModel.DataAnnotations;

namespace GymProyect.Web.Core.Entities._Core
{
    public abstract class Entity
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Creado por")]
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        protected Entity()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}
