using System;
using System.ComponentModel;
using System.Collections.ObjectModel;



namespace London2012
{
    public class GBfinderModel : INotifyPropertyChanged
    {
        public GBfinderModel()
        {
            this.Items = new ObservableCollection<GBfinderDetailModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<GBfinderDetailModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {

            // Sample data; replace with real data
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Andrew Selby",
                DOB = "DOB: 25/12/88",
                Location = "Location: Barry",
                BioData = "Born in Barry, South Wales, Andrew is a gifted and stylish boxer with one of the most impressive medal collections in the GB Boxing squad. He won a bronze medal at the European Championships in Liverpool in 2008 and again in Moscow in 2010, boxing as a 54kg Bantamweight."
                + Environment.NewLine + Environment.NewLine + "Following changes to the Olympic weight categories he dropped down to Flyweight (52kg) in the latter part of 2010 and in 2011 he overcame initial problems with the lower weight with a spectacular run of results that saw him make the finals of both the European and the World Championships."
                + Environment.NewLine + Environment.NewLine + "In June 2011, Andrew (and fellow countryman, Fred Evans) made history by becoming the first Welshman for 86 years to win gold at the European Championship when he defeated Russia’s Georgy Balakshin, 13-10 in the final in Ankara.",
                Picture = "ProfilePics/AndrewSelby.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Anthony Joshua",
                DOB = "DOB: 15/10/89",
                Location = "Location: London",
                BioData = "22 year-old Anthony Joshua grew-up in Watford and lives in London after moving to the capital aged 14. He started boxing when he was 18 after his cousin Gbenga Ileyemi (2011 ABA Champion at 91kg) took him to Finchley ABC."
                + Environment.NewLine + Environment.NewLine + "A naturally gifted sportsman, who played football to high standard and regularly ran the 100m in less-than 11 seconds as a teenager, Anthony quickly rose through the ranks and in May 2010 he became Senior ABAE Champion at 91kg+."
                + Environment.NewLine + Environment.NewLine + "International recognition followed and in the summer of 2010 he was added to GB Boxing’s Development Squad. In November 2010 he became Champion of Great Britain when he defeated Amin Isa at the GB Championships and May 2011 he retained his ABAE title.",
                Picture = "ProfilePics/AnthonyJoshua.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Ben Ainslie",
                DOB = "DOB: 15/10/89",
                Location = "Location: ",
                BioData = "Ben Ainslie is Britain’s most successful Olympic sailor ever, with three gold and one silver medal."
                + Environment.NewLine + Environment.NewLine + "He made his Olympic debut aged 19 taking silver in the one-person Laser dinghy class at Atlanta 1996 before turning the tables on Brazilian great Robert Scheidt in Sydney four years later to claim his first gold."
                + Environment.NewLine + Environment.NewLine + "A move up to the heavyweight dinghy Finn class for Athens 2004 resulted in the same outcome, before victory at Beijing 2008 saw Ainslie surpass Rodney Pattison’s previous best British Olympic sailing haul of two golds, one silver."
                + Environment.NewLine + Environment.NewLine + "The three-time ISAF World Sailor of the Year has won the Finn World Championship a record five times, and in 2011 Ainslie claimed victory at both Skandia Sail for Gold and the Olympic Test Event at the London 2012 venue in Weymouth and Portland.",
                Picture = "ProfilePics/BenAinslie.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Fred Evans",
                DOB = "DOB: 04/02/91",
                Location = "Location: Cardiff",
                BioData = "Fred first visited a boxing club at the age of four and had his first bout as a 10 year old. Identified as a fearless boxer with renowned ring skills from a young age, he won gold at the European Cadet Championships in Hungary in 2007 and attended the 2008 Beijing Olympics, aged 17, as part of the BOA’s Olympic Ambition Scheme."
                + Environment.NewLine + Environment.NewLine + "He joined the GB Boxing Development squad in 2009 and was promoted to the Podium squad in March 2010 after an impressive performance at the Commonwealth Boxing Championships in Delhi where he won gold."
                + Environment.NewLine + Environment.NewLine + "In June 2011, he made history alongside his teammate, Andrew Selby, when they became the first Welshmen for 86 years to win gold at the European Championships in Ankara when he outpointed Mahamed Nurudzinau of Belarus, 15-9, in the final. In October of the same year, he qualified for the Olympic Games by reaching the last eight at the World Championships in Baku, Azerbaijan.",
                Picture = "ProfilePics/FredEvans.jpg"
            });

            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Mara Yamauchi",
                DOB = "DOB: 13/08/73",
                Location = "Location: Teddington, Middlesex",
                BioData = "After making the European Cross Country team in 1997, Mara went to work as a diplomat in Japan for the Foreign & Commonwealth Office and dropped out of athletics for a couple of years. In 2005, the Japanese-based athlete made a breakthrough on the world stage as she lowered her lifetime best from 2:39:16 to 2:31:52 in London, before finishing 18th at the World Championships in Helsinki in 2:31:26 and in her third marathon in seven months, Yamauchi improved again with 2:27:38 in Tokyo. "
                + Environment.NewLine + Environment.NewLine + "In 2006, she picked up a bronze medal in the Commonwealth Games over 10,000m and improved to 2:25:13 in the London Marathon and at the 2007 World Championships, Yamauchi finished a creditable ninth in blistering conditions. The Harrow AC athlete won the Osaka Marathon in January 2008 in 2:25.10 and was a fine sixth in the Beijing Olympics, which equalled the best ever performance by a British woman at the Olympic Games.",
                Picture = "ProfilePics/MaraYamauchi.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Kate Macgregor",
                DOB = "DOB: ",
                Location = "Location: Poole",
                BioData = "London 2012 will be Kate Macgregor’s Olympic Games debut following the introduction of Women’s Match Racing as an Olympic discipline."
                + Environment.NewLine + Environment.NewLine + "The younger sister of skipper Lucy, life turned on its head for ‘Mini Mac’, as she is known in the team ranks, in 2011. In the autumn of 2010, she was starting the second year of her Business degree at Southampton Solent University, every now and then helping out Lucy and Annie Lush as a training partner for their 2012 campaign. She was also part of Lucy’s team that won the 2010 ISAF Women’s World Match Racing title."
                + Environment.NewLine + Environment.NewLine + " Kate joined Lucy and Annie full-time at the start of 2011 and since then the trio won their first ISAF World Cup gold in Hyeres in April, before claiming silver at June’s Skandia Sail for Gold World Cup Regatta.",
                Picture = "ProfilePics/KateMacgregor.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Luke Campbell",
                DOB = "DOB: 27/09/87",
                Location = "Location: Hull",
                BioData = "Inspired by Muhammed Ali and Roy Jones, Luke took up boxing at the age of 13 when he visited a gym in Hull with his brother, Kane. He was selected to box for England as a 15 year old and in 2007 he won his first senior ABAE Championship, which he retained in 2008, and joined the GB Boxing squad at the age of 19."
                + Environment.NewLine + Environment.NewLine + "He narrowly missed-out to Joe Murray on selection for the 2008 Olympics but later that year he became the first boxer since 1961 to win a European Championship gold medal for Great Britain when he defeated Detelin Dalakliev of Bulgaria by countback in a tense final in Liverpool after the scores had finished 5-5."
                + Environment.NewLine + Environment.NewLine + "In 2009 he was named Amateur Boxer of the Year by the Boxing Writers Club of Great Britain however a hand injury prevented him from competing for 10 months of the year."
                + Environment.NewLine + Environment.NewLine + "In 2010, Luke began a run that would see him go 23 bouts unbeaten and led GB Boxing’s Performance Director to describe him as the “benchmark” for the rest of the boxers in the squad.",
                Picture = "ProfilePics/LukeCampbell.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Luke Patience",
                DOB = "DOB: 04/08/86",
                Location = "Location: Helensburgh",
                BioData = "Luke started sailing in an Optimist at the age of seven and began racing two years later at his local sailing club, Royal Northern and Clyde Yacht Club, Helensburgh. Luke teamed up with Stuart Bithell in the men’s 470 double-handed dinghy in 2009 and the 470 duo have gone from strength to strength ever since confirming their positions as GB’s front runners in the men’s 470 class."
                + Environment.NewLine + Environment.NewLine + "In 2009, the pair exceeded even the most optimistic expectations during their relatively short time together. They claimed a silver medal at the 2009 470 World Championships, after being together for only two weeks. Luke and his crew member Stuart went onto to achieve the same outcome at the Skandia Sail for Gold Regatta in June 2009."
                + Environment.NewLine + Environment.NewLine + "A string of impressive podium finishes saw Luke and his partner Stuart climb up to fourth in the ISAF World Rankings by the end of 2010.",
                Picture = "ProfilePics/LukePatience.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Paula Radcliffe",
                DOB = "DOB: 18/12/77",
                Location = "Location: Helensburgh",
                BioData = "A hugely coveted long distance runner, Paula has been named British Female Athlete of the Year an unprecedented five times while also winning the IAAF World Female Athlete of the Year in 2002. Her athletics has taken a back seat in recent seasons with the birth of her two children, but in 2011 Paula made her comeback and she came back with a bang at the Berlin Marathon, which sealed her qualification for London 2012. She is a graduate from Loughborough University with a degree in European Languages. The 37-year-old’s inclusion to Team GB makes Radcliffe the third British athlete to be selected for five Olympics, following in the footsteps of Tessa Sanderson and Chris Maddocks and she will be the first to compete in three marathons.",
                Picture = "ProfilePics/PaulaRadcliffe.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Paul Goodison",
                DOB = "DOB: 29/11/77",
                Location = "Location: Weymouth",
                BioData = "Paul Goodison is currently the World Number one laser sailor, holding the Olympic, European, World and British titles. At the Beijing 2008, Olympic Games Goodison competed in the laser class and won Olympic gold."
                + Environment.NewLine + Environment.NewLine + "In 2009 Goodison won his fifth consecutive European Laser title. In August he then went on to win his first World Laser Title in Halifiax. Goodison remained undefeated since Beijing until he placed fifth at the Sail for Gold Regatta in Weymouth in September."
                + Environment.NewLine + Environment.NewLine + "Goodison has one of the best Laser sailing records in the world having finished within the top ten in 84% of all the Olympic Classes events he has entered over the past decade."
                + Environment.NewLine + Environment.NewLine + "Goodison started sailing aged four with his father in a National 12. Since turning professional in 1996 he has put together a most impressive string of results. Goodison’s first major success came in the 2000 Laser European Championships where he won silver.",
                Picture = "ProfilePics/PaulGoodison.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Saskia Clark",
                DOB = "DOB: 23/08/79",
                Location = "Location: West Mersea",
                BioData = "London 2012 will be Saskia Clark’s second Olympic outing, having made her Games debut in the 470 with Christina Bassadone at Beijing 2008."
                + Environment.NewLine + Environment.NewLine + "The 2007 Worlds bronze medallists finished sixth in China and after Bassadone’s post-Games retirement crew Clark trialled with a number of different helms including Beijing 2008 Laser Radial representative Penny Clark, and 2008 Olympic Yngling champion teammates Pippa Wilson and Sarah Ayton. "
                + Environment.NewLine + Environment.NewLine + "In February 2011, Clark teamed up with promising talent, Hannah Mills, and their success was almost instant as they won silver at Hyeres in April in only their second regatta together. The new pairing achieved the same outcome at Skandia Sail for Gold Regatta in June and in August, just six months after getting together, they won Olympic Test Event silver at the London 2012 venue in Weymouth and Portland.",
                Picture = "ProfilePics/SaskiaClark.jpg"
                               });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Scott Overall",
                DOB = "DOB: 09/02/83",
                Location = "Location: Sutton",
                BioData = "Scott Overall is the sole male representative to date, following his excellent marathon debut in Berlin. The 28-year-old met the UKA ‘A’ standard when he finished fifth, in a time of two hours, 10 minutes and 55 seconds. The Londoner derives from a 5,000m background but swapped the track for the roads only this calendar year.",
                Picture = "ProfilePics/ScottOverall.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Stuart Bithell",
                DOB = "DOB: ",
                Location = "Location: Portland",
                BioData = "Stuart Bithell was introduced to sailing as a seven-year-old at Hollingworth Lake Sailing Club, Rochdale in a firefly. Bithell began racing when he turned 12 and became a member of Skandia Team GBR Development Squad by the time he was 18. He raced against his fellow sailing partner, Luke Patience, when they were 15, however went on to form a partnership in 2009 in the men’s 470 double-handed dinghy. Bithell relocated from Rochdale to Portland four years ago – where the Olympic Sailing events will be held."
                + Environment.NewLine + Environment.NewLine + "In 2009, the pair exceeded even the most optimistic expectations during their relatively short time together. They claimed a silver medal at the 2009 470 World Championships, after being together for only two weeks. Bithell and his 470 partner Luke Patience went onto to achieve the same outcome at the Skandia Sail for Gold Regatta in June 2009."
                + Environment.NewLine + Environment.NewLine + "A string of impressive podium finishes saw Bithell climb up to fourth in the ISAF World Rankings by the end of 2010.",
                Picture = "ProfilePics/StuartBithell.jpg"
            });
            this.Items.Add(new GBfinderDetailModel()
            {
                aName = "Tom Stalker",
                DOB = "DOB: 30/06/84",
                Location = "Location: Liverpool",
                BioData = "A self-confessed teenage tearaway, Tom was a relatively late starter and did not take-up boxing until he was 18 as a means of ‘cleaning up his act’ following the death of his nan. He is now one of the most decorated boxers in the GB Boxing squad, is ranked number one in the world at his weight and coaches young children in his local community."
                + Environment.NewLine + Environment.NewLine + "Tom started boxing at St. Aloysius gym in Liverpool and, following his first bout at the age of 19, worked his way through the amateur ranks and into the GB Boxing squad. He missed out on selection for Beijing to Frankie Gavin, but soon established himself as the number one boxer at Lightweight (60kg) following Gavin’s decision to leave the amateur ranks in 2008."
                + Environment.NewLine + Environment.NewLine + "In 2010 Tom won a silver medal at the European Championships in Moscow and gold at the Commonwealth Games in Delhi where he was Captain of the England boxing team.",
                Picture = "ProfilePics/TomStalker.jpg"
            });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}