using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuSidesShouldContainAllSides()
        {
            Assert.Collection(
                Menu.Sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void SidesShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Sides.Count());
        }

        [Fact]
        public void MenuDrinksShouldContainAllDrinks()
        {
            Assert.Collection(
                Menu.Drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Fact]
        public void DrinksShouldOnlyHaveFourItems()
        {
            Assert.Equal(4, Menu.Drinks.Count());
        }

        [Fact]
        public void MenuEntreesShouldContainAllEntrees()
        {
            Assert.Collection(
                Menu.Entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },                
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); }                
                );
        }

        [Fact]
        public void EntreesShouldOnlyHaveSevenItems()
        {
            Assert.Equal(7, Menu.Entrees.Count());
        }

        [Fact]
        public void CompleteMenuShouldContainAllMenuItems()
        {
            Assert.Collection(
                Menu.CompleteMenu,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }

                );
        }

        [Fact]
        public void CompleteMenuShouldOnlyHaveFifteenItems()
        {
            Assert.Equal(15, Menu.CompleteMenu.Count());
        }
    }
}
