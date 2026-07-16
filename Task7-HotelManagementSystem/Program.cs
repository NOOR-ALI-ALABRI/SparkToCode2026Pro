namespace Task7_HotelManagementSystem;

public class Room
{     // Attributes
    public string RoomNumber { get; set; }
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
    public string RoomNumber { get; set; }
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


   public static void RegisterNewGuest(List<Guest> guests)
   {
       Console.Write("Enter guest name: ");
       string guestName = Console.ReadLine();

       Console.Write("Enter check-in date: ");
       string checkInDate = Console.ReadLine();

       Console.Write("Enter total nights: ");
       int totalNights = int.Parse(Console.ReadLine());

       int number = guests.Count + 1;
       string guestId = "G00" + number;

       Guest newGuest = new Guest();

       newGuest.GuestId = guestId;
       newGuest.GuestName = guestName;
       newGuest.RoomNumber = "Not Assigned";
       newGuest.CheckInDate = checkInDate;
       newGuest.TotalNights = totalNights;

       guests.Add(newGuest);

       Console.WriteLine("Guest registered successfully!");
       newGuest.DisplayGuest();
   }



   static void BookRoom(List<Room> rooms, List<Guest> guests)
   {
       Console.Write("Enter guest ID: ");
       string guestId = Console.ReadLine();

       
       Console.Write("Enter room number: ");
       int roomNumber = int.Parse(Console.ReadLine());
 
       Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId); // 2. Find guest using FirstOrDefault()

       if (guest == null)
       {
           Console.WriteLine("Guest not found.");
           return;
       }

       Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber); // 3. Find room using FirstOrDefault()

       if (room == null)
       {
           Console.WriteLine("Room not found.");
           return;
       }
       
       if (!room.IsAvailable)
       {
           Console.WriteLine("Room is already booked.");
           return;
       }
       // Link guest with room
       guest.RoomNumber = room.RoomNumber;

       //  Change room status to booked
       room.IsAvailable = false;


       // Display booking confirmation
       Console.WriteLine("Booking successful!");
       Console.WriteLine("--------------------");
       Console.WriteLine("Guest Name: " + guest.GuestName);
       Console.WriteLine("Room Number: " + room.RoomNumber);
       Console.WriteLine("Room Type: " + room.RoomType);
       Console.WriteLine("Price Per Night: " + room.PricePerNight);
       Console.WriteLine("Total Nights: " + guest.TotalNights);
       Console.WriteLine("Total Cost: " + guest.CalculateTotalCost(room.PricePerNight));
   }


   static void ViewAllRooms(List<Room> rooms)
   {
       if (rooms.Count == 0)
       {
           Console.WriteLine("No rooms have been added yet.");
           return;
       }

       Console.WriteLine("Total Rooms: " + rooms.Count);

       var roomList = rooms.OrderBy(r => r.RoomNumber).Select(r => r);


       foreach (var room in roomList)
       {
           Console.WriteLine("--------------------");
           Console.WriteLine("Room Number: " + room.RoomNumber);
           Console.WriteLine("Room Type: " + room.RoomType);
           Console.WriteLine("Price: " + room.PricePerNight);
           Console.WriteLine("Status: " + (room.IsAvailable ? "Available" : "Booked"));
       }
   }



   static void ViewAllGuests(List<Guest> guests)
   {
       if (guests.Count == 0)
       {
           Console.WriteLine("No guests have been registered yet.");
           return;
       }
       Console.WriteLine("Total Guests: " + guests.Count);    
       var guestList = guests.OrderBy(g => g.GuestName);
       foreach (var guest in guestList)
       {
           Console.WriteLine("--------------------");
           Console.WriteLine("Guest ID: " + guest.GuestId);
           Console.WriteLine("Guest Name: " + guest.GuestName);
           Console.WriteLine("Room Number: " + guest.RoomNumber);
           Console.WriteLine("Check In Date: " + guest.CheckInDate);
           Console.WriteLine("Total Nights: " + guest.TotalNights);
       }
       
   }


///////////////////////////////////////////////////////////////
//MEDIUM | Cases 06 – 10  

   public static void SearchAndFilterRooms(List<Room> rooms)
   {
       while (true)
       {
           Console.WriteLine("1. Show all available rooms");
           Console.WriteLine("2. Filter by room type");
           Console.WriteLine("3. Filter by max price");
           Console.WriteLine("4. Room price statistics");
           Console.WriteLine("0. Back");

           Console.Write("Enter choice: ");
           int choice = int.Parse(Console.ReadLine());
           
           if (choice == 0)
           {
               return;
           }


           switch (choice)
           {
               case 1:
                   ShowAvailableRooms(rooms);
                   break;

               case 2:
                   FilterByRoomType(rooms);
                   break;

               case 3:
                   FilterByMaxPrice(rooms);
                   break;

               case 4:
                   RoomStatistics(rooms);
                   break;
               default:
                   Console.WriteLine("Invalid choice. Try again.");
                   break;
           }
           
           }
   }
   
   static void ShowAvailableRooms(List<Room> rooms)
   {var availableRooms = rooms.Where(r => r.IsAvailable)
       .OrderBy(r => r.PricePerNight);
       Console.WriteLine("Available Rooms Count: " + availableRooms.Count());
       
       if (!availableRooms.Any())
       {
           Console.WriteLine("No rooms found for the selected criteria.");
           return;
       }


       foreach (var room in availableRooms)
       {
           Console.WriteLine("----------------");
           Console.WriteLine("Room Number: " + room.RoomNumber);
           Console.WriteLine("Type: " + room.RoomType);
           Console.WriteLine("Price: " + room.PricePerNight.ToString("0.00"));
       }
      
   } //case1


   static void FilterByRoomType(List<Room> rooms) //case2
   {
       Console.Write("Enter room type: ");
       string type = Console.ReadLine();
       var result = rooms.Where(r => r.RoomType == type);
       Console.WriteLine("Rooms Found: " + result.Count());
       if (!result.Any())
       {
           Console.WriteLine("No rooms found for the selected criteria.");
           return;
       }


       foreach (var room in result)
       {
           Console.WriteLine(room.RoomNumber + " - " + room.RoomType);
       }

   }


   static void FilterByMaxPrice(List<Room> rooms)//case3
   {
       Console.Write("Enter maximum price: ");
       double price = double.Parse(Console.ReadLine());
       var result = rooms.Where(r => r.IsAvailable && r.PricePerNight <= price)
           .OrderBy(r => r.PricePerNight);
        
       
       Console.WriteLine("Rooms Found: " + result.Count());
       
       if (!result.Any())
       {
           Console.WriteLine("No rooms found for the selected criteria.");
           return;
       }


       foreach (var room in result)
       {
           Console.WriteLine(room.RoomNumber + " - " + room.PricePerNight.ToString("0.00"));
       }
       
   }


   static void RoomStatistics(List<Room> rooms)//case4
   {
       Console.WriteLine("Total Rooms: " + rooms.Count());

       Console.WriteLine("Available Rooms: " + rooms.Count(r => r.IsAvailable));
       Console.WriteLine("Average Price: " + rooms.Average(r => r.PricePerNight).ToString("0.00"));

       Console.WriteLine("Cheapest Price: " + rooms.Min(r => r.PricePerNight).ToString("0.00"));

       Console.WriteLine("Highest Price: " + rooms.Max(r => r.PricePerNight).ToString("0.00"));
   }
   
   
   //Case 07
   static void GuestBookingStatistics(List<Guest> guests, List<Room> rooms)
   {   int totalGuests = guests.Count();

       int bookedGuests = guests
           .Where(g => g.RoomNumber != "Not Assigned")
           .Count();

       Console.WriteLine("Total Registered Guests: " + totalGuests);
       Console.WriteLine("Guests With Rooms: " + bookedGuests);
       
       // 2. Total rooms and booked rooms
       int totalRooms = rooms.Count();

       int bookedRooms = rooms
           .Count(r => !r.IsAvailable);

       Console.WriteLine("Total Rooms: " + totalRooms);
       Console.WriteLine("Booked Rooms: " + bookedRooms);
       
       // 3. Average
       var activeGuests = guests
           .Where(g => g.RoomNumber != "Not Assigned");


       if (!activeGuests.Any())
       {
           Console.WriteLine("No active bookings recorded.");
       }
       else
       {
           double averageNights = activeGuests
               .Average(g => g.TotalNights);

           Console.WriteLine("Average Nights: " + averageNights);
       }

       //Top 3 
       
       }


   //Case8
   static void UpdateRoomPrice(List<Room> rooms)
   {
       Console.Write("Enter room number: ");
       string roomNumber = Console.ReadLine()
           
       Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
       
       if (room == null)
       {
           Console.WriteLine("Room not found.");
           return;
       }
       //  Ask new price
       Console.Write("Enter new price per night: ");
       double newPrice = double.Parse(Console.ReadLine());


       if (newPrice <= 0)
       {
           Console.WriteLine("Invalid price.");
           return;
       }
       double oldPrice = room.PricePerNight;
       room.PricePerNight = newPrice;

       Console.WriteLine("Room price updated successfully!");
       Console.WriteLine("Room Number: " + room.RoomNumber);
       Console.WriteLine("Old Price: " + oldPrice);
       Console.WriteLine("New Price: " + room.PricePerNight);

   }

  //Case 09 
   static void GuestLookupByName(List<Guest> guests)
   {
       Console.Write("Enter guest name: ");
       string searchName = Console.ReadLine();
       
       var result = guests
           .Where(g => g.GuestName
               .ToLower()
               .Contains(searchName.ToLower()));
       
       Console.WriteLine("Matches Found: " + result.Count());

      // If no matches
       if (!result.Any())
       {
           Console.WriteLine("No guests matched that search.");
           return;
       }
       foreach (var guest in result)
       {
           Console.WriteLine("----------------");
           Console.WriteLine("Guest ID: " + guest.GuestId);
           Console.WriteLine("Guest Name: " + guest.GuestName);
           Console.WriteLine("Room Number: " + guest.RoomNumber);
       }
       
   }