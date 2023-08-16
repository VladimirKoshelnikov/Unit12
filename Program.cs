using System;
using System.IO;

namespace Unit12{
    static class Program{
        
        static void Main(){

                User[] Users = new User[5];
                Users[0] = new User(login:"Login1", name: "Name1", isPremium: true);
                Users[1] = new User(login:"Login2", name: "Name2", isPremium: false);
                Users[2] = new User(login:"Login3", name: "Name3", isPremium: true);
                Users[3] = new User(login:"Login4", name: "Name4", isPremium: false);
                Users[4] = new User(login:"Login5", name: "Name5", isPremium: true);
                Controller.Greetings(Users);
        }
    }
}