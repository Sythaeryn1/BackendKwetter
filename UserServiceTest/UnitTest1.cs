using UserService.Models;

namespace UserServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserDTOConstructorSuccess()
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

            Assert.IsTrue(userDTO.Id == expectedUserDTO.Id &&
                userDTO.Name.Equals(expectedUserDTO.Name) &&
                userDTO.Location.Equals(expectedUserDTO.Location) &&
                userDTO.Bio.Equals(expectedUserDTO.Bio));
            
        }
    }
}