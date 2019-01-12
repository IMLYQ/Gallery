using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gallery.Models
{
    public class InsertData : DropCreateDatabaseIfModelChanges<PhotoDBcontext>
    {

        protected override void Seed(PhotoDBcontext context)
        {
            AddPlace(context);
            AddPhoto(context);
        }

        private static void AddPhoto(PhotoDBcontext context)
        {
            var photoes = new List<photo>
            {
                 new photo{ name="九曲—曲一.jpg",url="/IMG/九曲溪/九曲—曲一.jpg", placeID=1, content="九曲第一曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲二.jpg",url="/IMG/九曲溪/九曲—曲二.jpg", placeID=1, content="九曲第二曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲三.jpg",url="/IMG/九曲溪/九曲—曲三.jpg", placeID=1, content="九曲第三曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲四.jpg",url="/IMG/九曲溪/九曲—曲四.jpg", placeID=1, content="九曲第四曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲五.jpg",url="/IMG/九曲溪/九曲—曲五.jpg", placeID=1, content="九曲第五曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲七.jpg",url="/IMG/九曲溪/九曲—曲七.jpg", placeID=1, content="九曲第七曲", shootingtime=DateTime.Now},
                 new photo{ name="九曲—曲八.jpg",url="/IMG/九曲溪/九曲—曲八.jpg", placeID=1, content="九曲第八曲", shootingtime=DateTime.Now},
                 new photo{ name="碧水.jpg",url="/IMG/九曲溪/碧水.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="撑船足迹.jpg",url="/IMG/九曲溪/撑船足迹.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="蛤蟆石.jpg",url="/IMG/九曲溪/蛤蟆石.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="虹桥板.jpg",url="/IMG/九曲溪/虹桥板.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="静水.jpg",url="/IMG/九曲溪/静水.jpg", placeID=1, content="水太静，不忍心打扰", shootingtime=DateTime.Now},
                 new photo{ name="九曲看双乳峰.jpg",url="/IMG/九曲溪/九曲看双乳峰.jpg", placeID=1, content="坐竹筏从九曲溪看背面的双乳峰", shootingtime=DateTime.Now},
                 new photo{ name="流水.jpg",url="/IMG/九曲溪/流水.jpg", placeID=1, content="从石壁自上而下的流水", shootingtime=DateTime.Now},
                 new photo{ name="绿水.jpg",url="/IMG/九曲溪/绿水.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="面包.jpg",url="/IMG/九曲溪/面包.jpg", placeID=1, content="形如面包似的山，不记得叫什么名字了", shootingtime=DateTime.Now},
                 new photo{ name="千年悬棺.jpg",url="/IMG/九曲溪/千年悬棺.jpg", placeID=1, content="悬崖峭壁上有石洞，石洞中有一悬棺，不知道当时是怎么运上去的", shootingtime=DateTime.Now},
                 new photo{ name="三打白骨精取景.jpg",url="/IMG/九曲溪/三打白骨精取景.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="山山水水.jpg",url="/IMG/九曲溪/山山水水.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="山水合一.jpg",url="/IMG/九曲溪/山水合一.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="水清.jpg",url="/IMG/九曲溪/水清.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="水至清.jpg",url="/IMG/九曲溪/水至清.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="天游峰另路.jpg",url="/IMG/九曲溪/天游峰另路.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天河取景处.jpg",url="/IMG/九曲溪/通天河取景处.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天河取景二.jpg",url="/IMG/九曲溪/通天河取景二.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天河取景二.jpg",url="/IMG/九曲溪/通天河取景二.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天河取景三.jpg",url="/IMG/九曲溪/通天河取景三.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天河取景四.jpg",url="/IMG/九曲溪/通天河取景四.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天桥全景.jpg",url="/IMG/九曲溪/通天桥全景.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="卧龙潭.jpg",url="/IMG/九曲溪/卧龙潭.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="溪流.jpg",url="/IMG/九曲溪/溪流.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="小九曲.jpg",url="/IMG/九曲溪/小九曲.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="小浪.jpg",url="/IMG/九曲溪/小浪.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="竹筏沁水.jpg",url="/IMG/九曲溪/竹筏沁水.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="水中花.jpg",url="/IMG/九曲溪/水中花.jpg", placeID=1, content="", shootingtime=DateTime.Now},
                 new photo{ name="杂草.jpg",url="/IMG/天游峰/杂草.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="溪流.jpg",url="/IMG/天游峰/溪流.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="游鱼.jpg",url="/IMG/天游峰/游鱼.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="通天桥.jpg",url="/IMG/天游峰/通天桥.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="游鱼.jpg",url="/IMG/天游峰/游鱼.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="武夷山.jpg",url="/IMG/天游峰/武夷山.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="翘石壁.jpg",url="/IMG/天游峰/翘石壁.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="山岩.jpg",url="/IMG/天游峰/山岩.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="天游峰一角.jpg",url="/IMG/天游峰/天游峰一角.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="天游峰中.jpg",url="/IMG/天游峰/天游峰中.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="俯瞰第六曲.jpg",url="/IMG/天游峰/俯瞰第六曲.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="俯瞰九曲溪.jpg",url="/IMG/天游峰/俯瞰九曲溪.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="天游峰顶.jpg",url="/IMG/天游峰/天游峰顶.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="俯瞰一线天.jpg",url="/IMG/天游峰/俯瞰一线天.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="朱熹园.jpg",url="/IMG/天游峰/朱熹园.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="中正公园.jpg",url="/IMG/天游峰/中正公园.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="礼学正宗.jpg",url="/IMG/天游峰/礼学正宗.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="朱熹.jpg",url="/IMG/天游峰/朱熹.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="九曲棹歌.jpg",url="/IMG/天游峰/九曲棹歌.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="彼岸花.jpg",url="/IMG/天游峰/彼岸花.jpg", placeID=2, content="", shootingtime=DateTime.Now},
                 new photo{ name="厦门港.jpg",url="/IMG/海滨沙滩/厦门港.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="海的近岸.jpg",url="/IMG/海滨沙滩/海的近岸.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="浪花.jpg",url="/IMG/海滨沙滩/浪花.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="浪花退去.jpg",url="/IMG/海滨沙滩/浪花退去.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="流沙.jpg",url="/IMG/海滨沙滩/流沙.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="沙.jpg",url="/IMG/海滨沙滩/沙.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="沙滩.jpg",url="/IMG/海滨沙滩/沙滩.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="落日.jpg",url="/IMG/海滨沙滩/落日.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="晚霞.jpg",url="/IMG/海滨沙滩/晚霞.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="余晖.jpg",url="/IMG/海滨沙滩/余晖.jpg", placeID=3, content="", shootingtime=DateTime.Now},
                 new photo{ name="夕阳.jpg",url="/IMG/海滨沙滩/夕阳.jpg", placeID=3, content="", shootingtime=DateTime.Now},


            };
            photoes.ForEach(s => context.photo.Add(s));
            context.SaveChanges();
        }

        private static void AddPlace(PhotoDBcontext context)
        {
            var places = new List<place>
           {
               new place{ placename="九曲溪"},
               new place{ placename="天游峰"},
               new place{ placename="海滨沙滩"},
               new place{ placename="鼓浪屿"},
           };
            places.ForEach(s => context.place.Add(s));
            context.SaveChanges();
        }
    }
}