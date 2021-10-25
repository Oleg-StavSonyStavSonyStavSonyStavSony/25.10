
namespace _25._10
{


public class User {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User (){
            FirstName = null;   
            LastName = null;    
            Age = 0;
        }
        public User (string first, string last, int age){
            FirstName = first;
            LastName = last;
            Age = age;
        }
        public override string ToString() =>  $"{FirstName}\n{LastName}-\n{Age}";
            
        
        
    }
}