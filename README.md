
# EasyReserve

Bei diesem Projekt handelt es sich um eine Webanwendung, die für die 
Reservierung von Konzert-Tickets verwendet wird

## Tema

* Zahra LATIF
* Rafif ABUABED

![Alt Text](https://github.com/BaharLatif/sj23-24-56akif-projekt-easyreserve/raw/main/C:\Users\homeoffice\Documents\3.Semester\MeineRepository\EasyReserve/image.png)


@startuml 

class User {
   + Firstname : String 
   + lastname : String 
   + phonenumber : string (10)
   + Email : string 
   + username : string 
}
class Admin {
   + Users : List<User>

}
class Customer{
   + Tickets : List<Ticket>
   + PaymentInfos : List<Payments>
}
class Ticket {
   + Number : long
   + Price : Decimal
   + SeatNumber : string 
   + OwnerName : string
   + Concert : Concert
}
enum TicketStates{
   Available
   Sold
   Canceled
}
class Payments { 
   + PaymentId : int
   + Payment Description : string 
   + Payment : Payment()
}
class Artist { 
   + Name : string 
   + Genre : string 
   + Concerts : List<Concert>
}
class Concert {
   + Artist : Artist 
   + Venue : Venue 
   + Ticket : Ticket 
}
class Venue {
   + Address : string 
   + Seats Amount : int 
   + Concert : Concert 
}

Admin --> User
User --> Customer
Customer *-- Ticket
Customer *-- Payments
Artist *-- Concert
Concert *-- Ticket
Venue o-- Concert
Ticket .. TicketStates

@enduml