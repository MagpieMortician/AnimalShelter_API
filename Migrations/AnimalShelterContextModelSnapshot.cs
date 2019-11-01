﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter_Api.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("AnimalShelter.Models.ShelterList", b =>
                {
                    b.Property<int>("ShelterListId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("KennelNumber")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PhotoPath")
                        .IsRequired();

                    b.HasKey("ShelterListId");

                    b.ToTable("ShelterList");

                    b.HasData(
                        new
                        {
                            ShelterListId = 1,
                            Age = 2,
                            AnimalType = "Alpaca",
                            Breed = "Suri",
                            Description = "Carla is sassy and loves big Open spaces. She is the leader of the al-Pack-as.",
                            Gender = "Female",
                            KennelNumber = "7E",
                            Name = "Carla",
                            PhotoPath = "wwwroot/uploads/Carla.jpg"
                        },
                        new
                        {
                            ShelterListId = 2,
                            Age = 8,
                            AnimalType = "Caiman",
                            Breed = "Cuvier's dwarf",
                            Description = "He may be small, but Ruddy is feisty. Watch your fingers!",
                            Gender = "Male",
                            KennelNumber = "1R",
                            Name = "Ruddy",
                            PhotoPath = "wwwroot/uploads/Ruddy.jpg"
                        },
                        new
                        {
                            ShelterListId = 3,
                            Age = 1,
                            AnimalType = "Frog",
                            Breed = "Tomato",
                            Description = "He's a  frog. He does froggy things. He loves the hand taxi. Will do a heckin' monch before trusting hand taxi.",
                            Gender = "Male",
                            KennelNumber = "5A",
                            Name = "Sticky",
                            PhotoPath = "wwwroot/uploads/Sticky.jpg"
                        },
                        new
                        {
                            ShelterListId = 4,
                            Age = 1,
                            AnimalType = "Dog",
                            Breed = "Chinese Crested",
                            Description = "Toad is a fashionista. If she isn't wearing a cute outfit, she shakes uncontrollably from her naked rage.",
                            Gender = "Female",
                            KennelNumber = "3D",
                            Name = "Toad",
                            PhotoPath = "wwwroot/uploads/King.jpg"
                        },
                        new
                        {
                            ShelterListId = 5,
                            Age = 3,
                            AnimalType = "Cat",
                            Breed = "Ragdoll",
                            Description = "Raggedy Anne is a very relaxed. Her favorite pastime is sleeping and getting attention.",
                            Gender = "Female",
                            KennelNumber = "3B",
                            Name = "Raggedy Anne",
                            PhotoPath = "wwwroot/uploads/Anne.jpg"
                        },
                        new
                        {
                            ShelterListId = 6,
                            Age = 1,
                            AnimalType = "Bird",
                            Breed = "Red Factor Canary",
                            Description = "Loves heavy metal music. You must give him the seed or he will fight you.",
                            Gender = "Male",
                            KennelNumber = "1B",
                            Name = "Blood",
                            PhotoPath = "wwwroot/uploads/Blood.jpg"
                        },
                        new
                        {
                            ShelterListId = 7,
                            Age = 12,
                            AnimalType = "Monkey",
                            Breed = "Emperor Tamerin",
                            Description = "King Arthor believes He is king of all animals. Will steal your heart and your Acai fruit.",
                            Gender = "Male",
                            KennelNumber = "7G",
                            Name = "King Arthor",
                            PhotoPath = "wwwroot/uploads/Toad.jpg"
                        },
                        new
                        {
                            ShelterListId = 8,
                            Age = 5,
                            AnimalType = "Crab",
                            Breed = "Chesapeake blue Crab",
                            Description = "Always Angry.",
                            Gender = "Male",
                            KennelNumber = "3F",
                            Name = "Crab",
                            PhotoPath = "wwwroot/uploads/Crab.jpg"
                        },
                        new
                        {
                            ShelterListId = 9,
                            Age = 20,
                            AnimalType = "Fish",
                            Breed = "Paedocypris progenetica",
                            Description = "So tiny, you can barely see her. Blubbles Just likes doing her own thing.",
                            Gender = "Female",
                            KennelNumber = "2F",
                            Name = "Blubbles",
                            PhotoPath = "wwwroot/uploads/Blub.jpg"
                        },
                        new
                        {
                            ShelterListId = 10,
                            Age = 7,
                            AnimalType = "Cougar",
                            Breed = "Cougar",
                            Description = "We aren't sure how we got Tom, but she seems friendly.",
                            Gender = "Female",
                            KennelNumber = "7V",
                            Name = "Tom",
                            PhotoPath = "wwwroot/uploads/Tom.jpg"
                        },
                        new
                        {
                            ShelterListId = 11,
                            Age = 15,
                            AnimalType = "Elephant",
                            Breed = "Borneo Elephant",
                            Description = "Borneo is smaller than he should be. He acts like a puppy dog, even loves playing catch.",
                            Gender = "Male",
                            KennelNumber = "5D",
                            Name = "Stompers",
                            PhotoPath = "wwwroot/uploads/Stompers.jpg"
                        },
                        new
                        {
                            ShelterListId = 12,
                            Age = 175,
                            AnimalType = "Dragon",
                            Breed = "Luck Dragon",
                            Description = "You mean... We have THE Falcore?! Falcore from the Never Ending Story?!",
                            Gender = "Male",
                            KennelNumber = "7H",
                            Name = "Falcore",
                            PhotoPath = "wwwroot/uploads/Flacore.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
