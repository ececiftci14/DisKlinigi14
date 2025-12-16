using System;

namespace DisKlinigi
{
    
    public abstract class BaseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public string EklenmeTarihi { get; set; } = DateTime.Now.ToString("dd.MM.yyyy");
    }
}