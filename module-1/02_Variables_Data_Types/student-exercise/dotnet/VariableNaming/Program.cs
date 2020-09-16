using System;

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

            int initialNumberOfRacoons = 3;
            int numberOfRacoonsEating = 2;
            int remainingNumberOfRacoons = initialNumberOfRacoons - numberOfRacoonsEating;

            Console.WriteLine("Only " + remainingNumberOfRacoons + " racoon remained after the others went home for dinner.");

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int beesLessThanFlowers = numberOfFlowers - numberOfBees;

            Console.WriteLine("There are " + beesLessThanFlowers + " more flowers than bees.");


            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int lonelyPigeon = 1;
            int newPigeon = 1;
            int pigeonsEatingBreadcrumbs = lonelyPigeon + newPigeon;

            Console.WriteLine("number of pigeons eating breadcrumbs " + pigeonsEatingBreadcrumbs);

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int originalFenceOwls = 3;
            int newFenceOwls = 2;
            int totalFenceOwls = originalFenceOwls + newFenceOwls;

            Console.WriteLine("There were " + totalFenceOwls + " owls on the fence.");

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int homeBuildingBeavers = 2;
            int swimmingBeavers = 1;
            int buildingBeaver = homeBuildingBeavers - swimmingBeavers;

            Console.WriteLine("The number of beavers buidling a home is " + buildingBeaver);

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int firstToucans = 2;
            int addToucan = 1;
            int totalToucans = firstToucans + addToucan;

            Console.WriteLine("There were " + totalToucans + " Toucans in the tree.");


            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int squirrels = 4;
            int nuts = 2;
            int extraSquirrels = squirrels - nuts;

            Console.WriteLine("When there are " + extraSquirrels + " more Squirrels than nuts, there will be a fight.");
            

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            int quarter = 25;
            int dime = 10;
            int twoNickels = 10;
            int mrsHiltsMoney = quarter + dime + twoNickels;

            Console.WriteLine("Mrs. Hilt has " + mrsHiltsMoney + " cents.");

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int mrsBriersClass = 18;
            int mrsMacAdamsClass = 20;
            int mrsFlannerysClass = 17;
            int firstGradeMuffins = mrsBriersClass + mrsMacAdamsClass + mrsFlannerysClass;

            Console.WriteLine("The first grade classes baked a total of " + firstGradeMuffins + " muffins.");

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            int yoyo = 24;
            int whistle = 14;
            int totalCost = yoyo + whistle;

            Console.WriteLine("Mrs. Hilt spent " + totalCost + " cents on a yoyo and a whistle.");

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;

            Console.WriteLine("Mrs. Hilt used " + totalMarshmallows + " marshmallows to make Rice Krispie Treats.");

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int hiltSnow = 29;
            int brecknockSnow = 17;
            int extraSnow = hiltSnow - brecknockSnow;

            Console.WriteLine("Mrs. Hilt got " + extraSnow + 
                " inches of snow more than Brecknock Elementary School.");

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            int hiltTenDollars = 10;
            int toyTruckCost = 3;
            int pencilCaseCost = 2;
            int hiltChange = hiltTenDollars - toyTruckCost - pencilCaseCost;

            Console.WriteLine("Mrs. Hilt has " + hiltChange + " dollars left after buying a toy truck and a pencil case.");

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int marbleCollection = 16;
            int lostMarbles = 7;
            int remainingMarbles = marbleCollection - lostMarbles;

            Console.WriteLine("Josh has only " + remainingMarbles + " marbles left after loosing some of his collection.");

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int seashellStart = 19;
            int completeSeashellCollection = 25;
            int lackingSeashells = completeSeashellCollection - seashellStart;

            Console.WriteLine("Megan needs " + lackingSeashells + " more seashells to complete her seashell collection.");

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int bradsBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = bradsBalloons - redBalloons;

            Console.WriteLine("Brad has " + greenBalloons + " green balloons.");

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int shelfBooks = 38;
            int addedBooks = 10;
            int newBookTotal = shelfBooks + addedBooks;

            Console.WriteLine("There are now " + newBookTotal + " books on the shelf.");

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int singleBeeLegs = 6;
            int eightBees = 8;
            int eightBeesLegs = singleBeeLegs * eightBees;

            Console.WriteLine("Eight bees have a total of " + eightBeesLegs + " legs.");

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            int iceCreamConePrice = 99;
            int doubleIceCreamCones = 2;
            int doubleIceCreamConesPrice = iceCreamConePrice * doubleIceCreamCones;

            Console.WriteLine("The cost of two ice cream cones is " + doubleIceCreamConesPrice + " cents.");

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int completeBorder = 125;
            int hiltsRocks = 64;
            int neededRocks = completeBorder - hiltsRocks;

            Console.WriteLine("Mrs. Hilt needs " + neededRocks + " rocks to complete her border.");

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int hiltsMarbles = 38;
            int hiltsLostMarbles = 15;
            int hiltsRemainingMarbles = hiltsMarbles - hiltsLostMarbles
                ;

            Console.WriteLine("Mrs. Hilt\'s marble collection has " + hiltsRemainingMarbles + " marbles left.");

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int concertDistance = 78;
            int tripFirstLeg = 32;
            int tripSecondLeg = concertDistance - tripFirstLeg;

            Console.WriteLine("The second leg of the trip was " + tripSecondLeg + " miles.");

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */

            int satMorningShovel = 90;
            int satAfternoonShovel = 45;
            int satShoveling = satMorningShovel + satAfternoonShovel;

            Console.WriteLine("Mrs. Hilt needs to move somewhere warmer after spending " + satShoveling + " minutes shoveling snow on Saturday.");

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            int hotDogPrice = 50;
            int hiltsHotDogs = 6;
            int hiltHotDogCost = hotDogPrice * hiltsHotDogs;

            Console.WriteLine("Mrs. Hilt bought six hot dogs for " + hiltHotDogCost + " cents.");

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            int hiltsChange = 50;
            int pencilCost = 7;
            int pencilPurchase = hiltsChange / pencilCost;

            Console.WriteLine("Mrs. Hilt can buy " + pencilPurchase + " with her 50 cents.");

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;

            Console.WriteLine("Mrs. Hilt saw " + redButterflies + " red butterflies.");

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            int candyCost = 54;
            int katesPayment = 100;
            int katesChange = katesPayment - candyCost;

            Console.WriteLine("Kate got " + katesChange + " cents in change.");


            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int marksExistingTrees = 13;
            int marksNewTrees = 12;
            int marksTotalTrees = marksExistingTrees + marksNewTrees;

            Console.WriteLine("Mark will have " + marksTotalTrees + " after he finishes landscaping.");

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int hoursPerDay = 24;
            int daysTilGrandma = 2;
            int hoursTilGrandma = hoursPerDay * daysTilGrandma;

            Console.WriteLine("Joy will see her grandma in " + hoursTilGrandma + " hours.");

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int kimsCousins = 4;
            int gumGiftPerCousin = 5;
            int gumGiftTotal = kimsCousins * gumGiftPerCousin;

            Console.WriteLine("Kim will need " + gumGiftTotal + " pieces of gum to give to her cousins.");

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal dansMoney = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal dansChange = dansMoney - candyBarCost;

            Console.WriteLine("Dan has " + dansChange + " dollars left after buying a candy bar.");


            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int boatsOnTheLake = 5;
            int peopleOnBoats = 3;
            int peopleOnTheLake = boatsOnTheLake * peopleOnBoats;

            Console.WriteLine("There are " + peopleOnTheLake + " people on boats in the lake.");

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int ellensLegoCollection = 380;
            int ellensLostLegos = 57;
            int ellensRemainingLegos = ellensLegoCollection - ellensLostLegos;

            Console.WriteLine("Ellen lost 57 legos and has " + ellensRemainingLegos + " legos left.");

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int arthursBakedMuffins = 35;
            int eightyThreeMuffins = 83;
            int arthursMuffinsToBake = eightyThreeMuffins - arthursBakedMuffins;

            Console.WriteLine("Arthur needs to bake " + arthursMuffinsToBake + " more muffins to get to 83.");

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int willysExtraCrayons = willysCrayons - lucysCrayons;

            Console.WriteLine("Willy has " + willysExtraCrayons + " more crayons than Lucy.");

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickersPerPage = 10;
            int pagesOfStickers = 22;
            int numberofStickers = stickersPerPage * pagesOfStickers;

            Console.WriteLine("We have " + numberofStickers + " stickers.");

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            double numberOfCupcakes = 96.0;
            double numberOfChildren = 8;
            double cupcakesPerPerson = numberOfCupcakes / numberOfChildren;

            Console.WriteLine("Each child will get " + cupcakesPerPerson + " cupcakes.");

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int fortySevenCookies = 47;
            int cookiesPerJar = 6;
            int remainingCookies = fortySevenCookies % cookiesPerJar;

            Console.WriteLine("She will have " + remainingCookies + " cookies left over after filling the jars.");


            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int mariansCroissants = 59;
            int mariansNeighbors = 8;
            int croissantsMarianKeeps = mariansCroissants % mariansNeighbors;

            Console.WriteLine("Marian gets to keep " + croissantsMarianKeeps + " croissants after passing some out to her neighbors.");

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            double cookiesPerTray = 12.0;
            int twoHundredSeventySixCookies = 276;
            double traysNeededForCookies = twoHundredSeventySixCookies / cookiesPerTray;

            Console.WriteLine("Marian will need " + traysNeededForCookies + " trays to make 276 cookies.");

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pretzelsMadeByMarian = 480;
            double pretzelsPerServing = 12;
            double numberOfPretzelServings = pretzelsMadeByMarian / pretzelsPerServing;

            Console.WriteLine("Marian made " + numberOfPretzelServings + " servings of pretzels.");
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int mariansLemonCupcakes = 53;
            int mariansSavedCupcakes = 2;
            int cupcakesPerBox = 3;
            int boxesForOrphanage = (mariansLemonCupcakes - mariansSavedCupcakes) / cupcakesPerBox;

            Console.WriteLine("Marian gave " + boxesForOrphanage + " boxes of cupcakes to the orphanage and kept 2 for herself.");

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int preparedCarrotSticks = 74;
            int peopleEatingCarrots = 12;
            int leftoverCarrotSticks = preparedCarrotSticks % peopleEatingCarrots;

            Console.WriteLine("There were " + leftoverCarrotSticks + " carrot sticks remaining after 12 people ate them.");

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            double numberOfTeddyBears = 98.0;
            double teddysPerShelf = 7.0;
            double shelvesOfTeddys = numberOfTeddyBears / teddysPerShelf;

            Console.WriteLine("Susie and her sister need " + shelvesOfTeddys + " shelves for all of their teddy bears.");
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            double picturesPerAlbum = 20.0;
            double susiesMothersPictures = 480.0;
            double albumsForPicturees = susiesMothersPictures / picturesPerAlbum;

            Console.WriteLine("Susie\'s mother will need " + albumsForPicturees + " albums for all of her pictures.");

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int totalTradingCards = 94;
            int cardsPerBox = 8;
            int filledBoxes = totalTradingCards / cardsPerBox;
            int cardsInUnfilledBox = totalTradingCards % cardsPerBox;

            Console.WriteLine("Joe has " + filledBoxes + " full boxes of trading cards and one box with " + cardsInUnfilledBox + " cards in it.");

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int numberOfShelves = 10;
            int numberOfBooks = 210;
            int booksPerShelf = numberOfBooks / numberOfShelves;

            Console.WriteLine("Susie\'s father has " + booksPerShelf + " books on 10 shelves.");

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int cristinasCroissants = 17;
            int cristinasGuests = 7;
            int croissantsPerGuest = cristinasCroissants / cristinasGuests;

            Console.WriteLine("Christina\'s guests each get " + croissantsPerGuest + " croissants.");

            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            double singleRoomSqFt = 288;
            double billHrPerRoom = 2.15;
            double billFtPerHr = singleRoomSqFt / billHrPerRoom;
            double jillHrPerRoom = 1.90;
            double jillFtPerHr = singleRoomSqFt / jillHrPerRoom;
            double fiveRooms = 5;
            double fiveRoomSqFt = singleRoomSqFt * fiveRooms;
            double jillAndBillCombinedRate = jillFtPerHr + billFtPerHr;
            double jillAndBillFiveRooms = fiveRoomSqFt / jillAndBillCombinedRate;

            Console.WriteLine("It will take Jill and Bill " + jillAndBillFiveRooms + " hours to paint five rooms.");

            double hrsPerDay = 8;
            double sixHundredTwentyThreeRooms = 623;
            double sixHundredTwentyThreeSqFt = sixHundredTwentyThreeRooms * singleRoomSqFt;
            double hoursForSixHundredTwentyThreeRooms = sixHundredTwentyThreeSqFt / jillAndBillCombinedRate;
            double daysForSixHundredTwentyThreeRooms = hoursForSixHundredTwentyThreeRooms / hrsPerDay;

            Console.WriteLine("It will take Jill and Bill " + daysForSixHundredTwentyThreeRooms + " days to paint 623 rooms.");

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            string firstName = "Leslie";
            string lastName = "Wilson";
            string middleInitial = "A";
            string fullName = lastName +", " + firstName + ", " + middleInitial + ".";
            Console.WriteLine(fullName);

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

            double distanceNYToChicago = 800;
            double distanceTrainTravelled = 537;
            double percentOfTripCompleted = distanceTrainTravelled / distanceNYToChicago;


            Console.WriteLine("The train has travelled " + (percentOfTripCompleted*100) + " percent of it\'s trip from New York to Chicago.");


        }
    }
}
