using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShareProject.Models;

namespace Autism.Pages.Test
{
    public class IndexModel : PageModel
    {
        private readonly ShareProject.Models.DatabaseAutismContext _context;

        public IndexModel(ShareProject.Models.DatabaseAutismContext context)
        {
            _context = context;
        }

        public IList<Employer> Employer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employer != null)
            {
                Employer = await _context.Employer.ToListAsync();
            }
            //虽然代码很烂，但姑且能用
            //大概参考下吧
            //大概玩玩下，有问题再找我
            //那个我问你老师，penny说如果这样的话，那我们的admit panel 是不是不用了？
            //毕竟有这个page了嘛
            //比起那个，刚才你说佩恩怎么了
            //那个是我打错字哈哈哈
            //还是需要的，admin负责上传resources之类的玩意，guest看/下载那些资源
            //那就是说，我们还是需要吧db连接到我们之前做的admin page 嘛？
            //是
            //斯。wow..
            //那现在这个做好了之后，下一步要干啥？
            //够你们忙一阵子了，生成的代码是不能直接用的，需要改挺多东西，比如说upload文件需要给file input然后存到local storage/cloud storage再把path存进db
            //诶那样的话，我们需不需要做到只这样的程度？？毕竟这个有点太多东西了owo
            //至少也得把其中一个module的功能给搞定
            //哦哦...emmm，那样老师你觉得我们在拜五之前做得完不XD
            //有点困难吧哈哈
            //不过实际上presentation之前你们都还可以改
            //然后原定的presentation date我和Mr Jackie肯定是去不了了，我们去西马办点事情
            //要么延后要么提早，延后的可能性高点
            //决定了会在classroom里announce
            //诶，所以说拜五的due date就是一个摆设？
            //周五你们要交什么？
            //名义上的交code吧哈哈
            //code反正是上github，不需要你们zip了交上来。有需要交其他的东西？有没有要写report
            //Work products of your group assignment which include website source codes, database schema, git report url and presentation slides etc. can be archived(zip or rar) and uploaded in Google Classroom.
        //那实际上只需要git link和presentation slides，ppt不需要放太多东西，反正到时看的是website不是ppt里的截图。
        //wow,那样啊啊啊。啊哟，吓死我。
        //还是紧张点吧，死刑稍微延后而已。
        //那样不要啊啊
        //那样的额话，那今天就这样？我现在要做的大概就是增加那个create, delete 的那个column?
        //参考scaffold item把需要的pages design出来然后加点细节
        //wow,好的
        //那今天就这样？
        //哈哈哈，还是老师你要继续听XD
        //先撤了
        //好的！感谢老师哈哈
        //88
        //88呵呵
        }
    }
}
