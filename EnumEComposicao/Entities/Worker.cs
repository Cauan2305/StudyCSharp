using EnumEComposicao.Entities.Enums;

namespace EnumEComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double  BaseSalary { get; set; }
        
        public Department Department { get; set; }


    }
}