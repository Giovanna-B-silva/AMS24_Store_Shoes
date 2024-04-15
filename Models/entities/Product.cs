namespace AMST4StoreShoes.entities
{
     public class Product
     {
      public Guid id {get; set;}
      public string? Brand {get; set;}
      public Guid Colorid {get; set;}
      public Guid SizeId {get; set;}
      public Double Price {get; set;}
      public Double Stock  {get; set;}
      public bool IsActive {get; set;}//ativo ou não no estoque
      public DateTime CreateBy { get; set; }//hora
     } 
} 