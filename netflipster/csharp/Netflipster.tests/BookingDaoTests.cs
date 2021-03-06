﻿using Netflipster.Repository;
using NFluent;
using NUnit.Framework;

namespace Netflipster.tests
{
    [TestFixture]
    public class BookingDaoTests
    {
        [Test]
        public void Book_Ok()
        {
            var userId = UserHelper.Create();
            var actual = BookingDao.Book("3", 10, userId);
            Check.That(actual).IsTrue();
        }
    }
}
