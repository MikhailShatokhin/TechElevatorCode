namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int racoonsInWoods = 3;
            int racoonsWhoLeft = 2;
            int racoonsRemaining = racoonsInWoods - racoonsWhoLeft;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int lessBeesThanFlowers = numberOfFlowers - numberOfBees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int anotherPigeon = 1;
            int sumPigeonsEatingCrumbs = lonelyPigeon + anotherPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int originalOwls = 3;
            int newOwls = 2;
            int owlsSittingOnFence = originalOwls + newOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorkingOnHome = 2;
            int beaversSwimming = 1;
            int beaversWorkingOnHomeTwo = beaversWorkingOnHome - beaversSwimming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int originalToucans = 2;
            int newToucans = 1;
            int toucansSittingOnTreee = originalToucans + newToucans;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelVsNutsCount = squirrels - nuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = .25M;
            decimal dime = .1M;
            decimal nickel = .05M;
            decimal totalMoneyFound = quarter + dime + (nickel * 2);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int mrsBrier = 18;
            int mrsMacadams = 20;
            int mrsFlannery = 17;
            int totalMuffins = mrsBrier + mrsFlannery + mrsMacadams;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = .24M;
            decimal whistle = .14M;
            decimal totalCost = yoyo + whistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMellow = 8;
            int miniMellow = 10;
            int totalMellow = largeMellow + miniMellow;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int mrsHiltSnow = 29;
            int breckkncokSnow = 17;
            int hiltVSBreckSnow = mrsHiltSnow - breckkncokSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal mrsHiltMoney = 10M;
            decimal toyTruck = 3M;
            decimal pencil = 2M;
            decimal moneyLeftOver = mrsHiltMoney - toyTruck - pencil;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marbleColl = 16;
            int marblesLost = 7;
            int totalMarbles = marbleColl - marblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int megSeashells = 19;
            int goalSeashells = 25;
            int seashellRemainder = goalSeashells - megSeashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBallons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentBookCount = 38;
            int additionalBooks = 10;
            int totalBooks = currentBookCount + additionalBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int beeCount = 8;
            int totalBeeLegs = beeLegs * beeCount;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal coneCost = .99M;
            int coneCount = 2;
            decimal totalConeCost = coneCost * coneCount;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int totalRocksForBorder = 125;
            int currentRockCount = 64;
            int rocksNeeded = totalRocksForBorder - currentRockCount;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int mrsHiltMarbleCount = 38;
            int lostMarbles = 15;
            int remainingMarbles = mrsHiltMarbleCount - lostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMiles = 78;
            int milesDriven = 32;
            int milesLeft = totalMiles - milesDriven;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int satMorn = 90;
            int satAfternoon = 45;
            int totalTimeShoveling = satMorn + satAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totalDogs = 6;
            decimal dogCost = .50M;
            decimal totalDogCost = totalDogs * dogCost;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal mrsHiltMoneyTotal = .50M;
            decimal pencilCost = .07M;
            decimal totalPencilsPossible = mrsHiltMoneyTotal / pencilCost;
            int totalPencilsPossibleTwo = (int)totalPencilsPossible;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal pay = 1.00M;
            decimal candyCost = .54M;
            decimal changeGiven = pay - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int currentTreeCount = 13;
            int plantedTrees = 12;
            int totalTrees = currentTreeCount + plantedTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int totalDays = 2;
            int daysToHours = 24;
            int totalHoursTillGma = totalDays * daysToHours;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int totalCousins = 4;
            int gumPieces = 5;
            int totalGumNeeded = totalCousins * gumPieces;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danTotalMoney = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal danMoneyLeftOver = danTotalMoney - candyBarCost;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int totalBoats = 5;
            int peopleOnBoats = 3;
            int totalPeopleOnBoats = totalBoats * peopleOnBoats;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int totalLegos = 380;
            int lostLegos = 57;
            int legosRemaining = totalLegos - lostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int currentMuffinsBaked = 35;
            int totalMuffinsNeeded = 83;
            int remainingMuffinsNeeded = totalMuffinsNeeded - currentMuffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayon = 290;
            int crayonDifference = willyCrayons - lucyCrayon;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int totalStickerOnPage = 10;
            int totalPages = 22;
            int totalStickers = totalStickerOnPage * totalPages;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double cupcakeTotal = 100;
            double childrenTotal = 8;
            double cupcakePerChild = cupcakeTotal / childrenTotal;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int totalGingerbread = 47;
            int jarMaxContents = 6;
            int gingerbreadInJar = totalGingerbread % jarMaxContents;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissants = 59;
            int totalNeighbors = 8;
            int remainingCroissants = totalCroissants % totalNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int totalOatmeals = 276;
            int totalOatmealsOnTray = 12;
            int totalTraysNeeded = totalOatmeals / totalOatmealsOnTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int oneServing = 12;
            int totalPretzelServings = totalPretzels / oneServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalLemonCups = 53;
            int lemonsLeftAtHome = 2;
            int boxMaxContents = 3;
            int boxesGivenAway = (totalLemonCups - lemonsLeftAtHome) / boxMaxContents;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalCarrotSticks = 74;
            int totalPeopleAtBreakfast = 12;
            int carrotSticksRemaining = totalCarrotSticks % totalPeopleAtBreakfast;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int shelfMaxLimit = 7;
            int shelfRequirment = totalTeddyBears / shelfMaxLimit;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int totalPictures = 480;
            int albumMaxContents = 20;
            int albumsRequired = totalPictures / albumMaxContents;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int boxMax = 8;
            int unfilledBoxCardCount = totalTradingCards % boxMax;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooksGathered = 210;
            int shelfMax = 10;
            int shelfBookQty = totalBooksGathered / shelfMax;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double cristTotalCroissants = 17;
            double totalGuests = 7;
            double croissantsPerGuest = cristTotalCroissants / totalGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
            double billRate = (12 * 14) / 2.15;
            double jillRate = (12 * 14) / 1.9;
            double billAndJill = (5 * (12 * 14))/(billRate + jillRate);
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper";
            string middleName = "B";

            string fullnameConcat = lastName + ", " + firstName + " " + middleName + ".";
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            double nyToChDistance = 800.0;
            double trainTraveledDistance = 537.0;
            double percentageTraveledOne = (trainTraveledDistance / nyToChDistance)*100.0;
            int percentageTraveledTwo = (int)percentageTraveledOne;
        }
    }
}
