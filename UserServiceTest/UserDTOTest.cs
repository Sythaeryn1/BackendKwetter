using UserService.Models;

namespace UserServiceTest
{
    public class UserDTOTest
    {
        [Fact]
        public void Test1()
        {
            UserDTO userDTO = new UserDTO
            {
                Id = 1,
                Name = "Kevin",
                Location = "Test",
                Bio = "Een test"
            };

            UserDTO expectedUserDTO = new UserDTO
            {
                Id = 1,
                Name = "Kevin",
                Location = "Test",
                Bio = "Een test"
            };
            
            Assert.True(userDTO.Id == expectedUserDTO.Id &&
                userDTO.Name.Equals(expectedUserDTO.Name) &&
                userDTO.Location.Equals(expectedUserDTO.Location) &&
                userDTO.Bio.Equals(expectedUserDTO.Bio));
        }
    }
}