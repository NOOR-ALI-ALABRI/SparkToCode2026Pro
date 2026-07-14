namespace Task7_HotelManagementSystem;

public class Room
{     // Attributes
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
    // Method
    public void DisplayRoom()
    {
        Console.WriteLine("Room Number: " + RoomNumber);
        Console.WriteLine("Room Type: " + RoomType);
        Console.WriteLine("Price Per Night: " + PricePerNight);
        Console.WriteLine("Available: " + IsAvailable);
    }
}

public class Guest
{    // Attributes
    public string GuestId { get; set; }
    public string GuestName { get; set; }
    public int RoomNumber { get; set; }
    public DateTime CheckInDate { get; set; }
    public int TotalNights { get; set; }
    // Method
    public void DisplayGuest()
    {
        
            Console.WriteLine("Guest ID: " + GuestId);
            Console.WriteLine("Guest Name: " + GuestName);
            Console.WriteLine("Room Number: " + RoomNumber);
            Console.WriteLine("Check In Date: " + CheckInDate);
            Console.WriteLine("Total Nights: " + TotalNights);
        
    }

    public double CalculateTotalCost(double pricePerNight)
    {
        
        return TotalNights * pricePerNight;
    }
   
}



class Program
{
    static void Main(string[] args)
    {
       
        
        List<Room> rooms = new List<Room>();

        List<Guest> guests = new List<Guest>();
        while (true)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");

            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());


        }
    }
        
    }

   //EASY | Cases 01 – 05 
   static void AddNewRoom(List<Room> rooms)
   {
       Console.Write("Enter room number: ");    // 1. Enter room number
       int roomNumber = int.Parse(Console.ReadLine());
       
       bool exists = rooms.Any(r => r.RoomNumber == roomNumber); // 2. Check if room already exists

       if (exists)
       {
           Console.WriteLine("Room already exists.");
           return;
       }
       Console.Write("Enter room type (Single/Double/Suite): ");
       string roomType = Console.ReadLine();

       Console.Write("Enter price per night: ");
       double price = double.Parse(Console.ReadLine());

       // 4. Create new Room object
       Room newRoom = new Room();

       newRoom.RoomNumber = roomNumber;
       newRoom.RoomType = roomType;
       newRoom.PricePerNight = price;
       newRoom.IsAvailable = true;
       
       
       // 5. Add room to list
       rooms.Add(newRoom);
       
       // 6. Display success message
       Console.WriteLine("Room added successfully!");

       newRoom.DisplayRoom();

       Console.WriteLine("Total rooms: " + rooms.Count);

   }







}