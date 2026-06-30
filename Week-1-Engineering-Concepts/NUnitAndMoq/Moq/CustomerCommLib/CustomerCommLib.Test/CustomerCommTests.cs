using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommLib.Test;

[TestFixture]
public class CustomerCommTests
{
    [Test]
    public void SendMailToCustomer_ShouldReturnTrue_WhenMailIsSent()
    {
        // Arrange
        var mockMailSender = new Mock<IMailSender>();

        mockMailSender
            .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        var customerComm = new CustomerComm(mockMailSender.Object);

        // Act
        bool result = customerComm.SendMailToCustomer();

        // Assert
        Assert.That(result, Is.True);

        mockMailSender.Verify(
            x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()),
            Times.Once);
    }
}