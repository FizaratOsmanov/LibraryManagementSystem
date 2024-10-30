using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Concretes
{
    public class LibraryMemberService : ILibraryMemberService
    {

        public static List<LibraryMember> LibraryMembers;

        public LibraryMemberService()
        {
            LibraryMembers = new List<LibraryMember>();
        }

        public void CreateLibraryMember(LibraryMember libraryMember)
        {
            LibraryMembers.Add(libraryMember);
        }

        public void DeleteLibraryMember(int id, bool IsSoftDelete)
        {
            int index = -1;
            for (int i = 0; i < LibraryMembers.Count; i++)
            {
                if (id == LibraryMembers[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                if (IsSoftDelete)
                {
                    LibraryMembers[index].LibraryMemberStatus = Enums.LibraryMemberStatusEnum.Removed;
                }
                else
                {

                    LibraryMembers.Remove(LibraryMembers[index]);
                }
            }
            else
            {
                throw new Exception($"LibraryMember list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
            }
        }

        public List<LibraryMember> GetAllLibraryMembers()
        {
            return LibraryMembers;
        }

        public LibraryMember GetLibraryMemberById(int id)
        {
            int index = -1;
            for (int i = 0; i < LibraryMembers.Count; i++)
            {
                if (id == LibraryMembers[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return LibraryMembers[index];
            }
            else
            {
                throw new Exception($"LibraryMember list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
            }
        }

        internal void CreateLibraryMember(List<LibraryMember> libraryMember)
        {
            throw new NotImplementedException();
        }

        internal void CreateLibraryMember(object libraryMember)
        {
            throw new NotImplementedException();
        }

        internal List<Librarian> GetLibraryMemberById()
        {
            throw new NotImplementedException();
        }
    }
}
