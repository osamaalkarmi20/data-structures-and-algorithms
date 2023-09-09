using static data_structures_and_algorithms.Program;


namespace TestReserve
{

    public class UnitTest1
    {

        public class Sort
        {
            [Fact]
            public void SortByName_ShouldSortMoviesByTitleIgnoringArticles()
            {

                var movies = new List<Movie>
            {
                new Movie { Title = "The Lion King" },
                new Movie { Title = "Toy Story" },
                new Movie { Title = "Blade Runner" },
                new Movie { Title = "Saving Private Ryan" },
                new Movie { Title = "Scream" }
            };


                var sortedMovies = Sorting.SortByName(movies);

                Assert.Equal("Blade Runner", sortedMovies[0].Title);
                Assert.Equal("The Lion King", sortedMovies[1].Title);
                Assert.Equal("Saving Private Ryan", sortedMovies[2].Title);
                Assert.Equal("Scream", sortedMovies[3].Title);
                Assert.Equal("Toy Story", sortedMovies[4].Title);
            }

            [Fact]
            public void CompareTitles_ShouldCompareTitlesIgnoringArticles()
            {
                string title1 = "The Lion King";
                string title2 = "Toy Story";


                var result = Sorting.CompareTitles(title1, title2);


                Assert.True(result < 0);
            }

            [Fact]
            public void SortByYear_ShouldSortMoviesByYear()
            {

                var movies = new List<Movie>
            {
                new Movie { Title = "The Lion King", Year = 1994 },
                new Movie { Title = "Toy Story", Year = 1995 },
                new Movie { Title = "Blade Runner", Year = 1982 },
                new Movie { Title = "Saving Private Ryan", Year = 1998 },
                new Movie { Title = "Scream", Year = 1996 }
            };


                var sortedMovies = Sorting.SortByYear(movies);


                Assert.Equal(1982, sortedMovies[0].Year);
                Assert.Equal(1994, sortedMovies[1].Year);
                Assert.Equal(1995, sortedMovies[2].Year);
                Assert.Equal(1996, sortedMovies[3].Year);
                Assert.Equal(1998, sortedMovies[4].Year);
            }
        }
    }
}