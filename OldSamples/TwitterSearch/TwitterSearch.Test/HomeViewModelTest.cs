using Cirrious.MvvmCross.Platform;
using NUnit.Framework;
using TwitterSearch.Core.ViewModels;

namespace TwitterSearch.Test
{
    [TestFixture]
    public class HomeViewModelTest : MvxTest
    {
        [Test]
        public void GoCausesNoNavigationForBannedWord()
        {
            ClearAll();

            var mockNavigation = CreateMockNavigation();
            var viewModel = new HomeViewModel();
            var searchTerm = "javascript";
            viewModel.SearchText = searchTerm;
            viewModel.SearchCommand();
            Assert.AreEqual(0, mockNavigation.NavigateRequests.Count);
        }

        [Test]
        public void GoCausesNoNavigationForEmptySearch()
        {
            ClearAll();

            var mockNavigation = CreateMockNavigation();
            var viewModel = new HomeViewModel();
            var searchTerm = "";
            viewModel.SearchText = searchTerm;
            viewModel.SearchCommand();
            Assert.AreEqual(0, mockNavigation.NavigateRequests.Count);
        }

        [Test]
        public void GoCausesNavigationForNonEmptySearch()
        {
            ClearAll();

            Ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());
            var mockNavigation = CreateMockNavigation();

            var viewModel = new HomeViewModel();
            var searchTerm = "Test Search Term";
            viewModel.SearchText = searchTerm;
            viewModel.SearchCommand();
            Assert.AreEqual(1, mockNavigation.NavigateRequests.Count);
        }

        [Test]
        public void RandomChangesTheSearchTerm()
        {
            ClearAll();

            var viewModel = new HomeViewModel();
            var searchTerm = "Test Search Term";
            viewModel.SearchText = searchTerm;
            viewModel.PickRandomCommand();
            Assert.AreNotEqual(searchTerm, viewModel.SearchText);
        }
    }
}