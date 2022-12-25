using Microsoft.EntityFrameworkCore;
using Assign1.Models;
using System.Collections.Generic;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            GetStudents()
        );
    }

    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                StudentId = 1,
                FirstName = "Jim",
                LastName = "Potter",
                MobileNumber = "604-123-4567",
                EmailAddress = "jim@potter.com",
                CityOfResidence = "Chilliwack",
                Specialization = "Nursing"
            },

            new Student()
            {
                StudentId = 2,
                FirstName = "Jane",
                LastName = "Douglas",
                MobileNumber = "604-123-4567",
                EmailAddress = "jane@douglas.com",
                CityOfResidence = "Surrey",
                Specialization = "Nursing"
            },

            new Student()
            {
                StudentId = 3,
                FirstName = "Tom",
                LastName = "Gardner",
                MobileNumber = "604-123-4567",
                EmailAddress = "tom@gardner.com",
                CityOfResidence = "Vancouver",
                Specialization = "Welding"
            },

            new Student()
            {
                StudentId = 4,
                FirstName = "Ann",
                LastName = "Lee",
                MobileNumber = "604-123-4567",
                EmailAddress = "ann@lee.com",
                CityOfResidence = "Vancouver",
                Specialization = "Dentistry"
            },

            new Student()
            {
                StudentId = 5,
                FirstName = "James",
                LastName = "Jones",
                MobileNumber = "604-123-4567",
                EmailAddress = "james@jones.com",
                CityOfResidence = "Chilliwack",
                Specialization = "Nursing"
            },

            new Student()
            {
                StudentId = 6,
                FirstName = "Susan",
                LastName = "Taylor",
                MobileNumber = "604-123-4567",
                EmailAddress = "susan@taylor.com",
                CityOfResidence = "Surrey",
                Specialization = "Hospitality"
            },

            new Student()
            {
                StudentId = 7,
                FirstName = "Peter",
                LastName = "White",
                MobileNumber = "604-123-4567",
                EmailAddress = "peter@white.com",
                CityOfResidence = "Vancouver",
                Specialization = "Welding"
            },

            new Student()
            {
                StudentId = 8,
                FirstName = "Philip",
                LastName = "Fox",
                MobileNumber = "604-123-4567",
                EmailAddress = "philip@fox.com",
                CityOfResidence = "Vancouver",
                Specialization = "Dentistry"
            },

            new Student()
            {
                StudentId = 9,
                FirstName = "Donna",
                LastName = "Ray",
                MobileNumber = "604-123-4567",
                EmailAddress = "donna@ray.com",
                CityOfResidence = "Chilliwack",
                Specialization = "Nursing"
            },
        };
        return students;
    }
}
