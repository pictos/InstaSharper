using System;
using System.Linq;
using System.Threading.Tasks;
using InstaSharper.API;

namespace InstaSharper.Examples.Samples
{
    internal class Messaging : IDemoSample
    {
        private readonly IInstaApi _instaApi;

        public Messaging(IInstaApi instaApi)
        {
            _instaApi = instaApi;
        }

        public async Task DoShow()
        {
            //var recipientsResult = await _instaApi.GetRankedRecipientsAsync();
            //if (!recipientsResult.Succeeded)
            //{
            //    Console.WriteLine("Unable to get ranked recipients");
            //    return;
            //}
            //Console.WriteLine($"Got {recipientsResult.Value.Threads.Count} ranked threads");
            //foreach (var thread in recipientsResult.Value.Threads)
            //    Console.WriteLine($"Threadname: {thread.ThreadTitle}, users: {thread.Users.Count}");

            var inboxThreads = await _instaApi.GetDirectInboxAsync();
            if (!inboxThreads.Succeeded)
            {
                Console.WriteLine("Unable to get inbox");
                return;
            }
            //Console.WriteLine($"Got {inboxThreads.Value.Inbox.Threads.Count} inbox threads");
            //foreach (var thread in inboxThreads.Value.Inbox.Threads)
            //    Console.WriteLine($"Threadname: {thread.Title}, users: {thread.Users.Count}");
            //var firstThread = inboxThreads.Value.Inbox.Threads.FirstOrDefault();
            // send message to specific thread
            //var sendMessageResult = await _instaApi.SendDirectMessage($"{firstThread.Users.FirstOrDefault()?.Pk}",
            //    firstThread.ThreadId, "test");

            await _instaApi.LoginAsync().ConfigureAwait(false);
            var threadId = inboxThreads.Value.Inbox.Threads.FirstOrDefault().ThreadId;
            var oldCursor = inboxThreads.Value.Inbox.Threads.FirstOrDefault().OldestCursor;

            var msgEspecificas = await _instaApi.GetDirectInboxThreadAsync(threadId);
            var tet = msgEspecificas.Value.Items.Where(x => x.DirectMedia != null);
            var cursor = await _instaApi.GetDirectInboxCursorAsync(threadId,oldCursor);
            //msgEspecificas.Value.OldestCursor

            //var teste = false;

            //Console.WriteLine(sendMessageResult.Succeeded ? "Message sent" : "Unable to send message");

            // just send message to user (thread not specified)
            //sendMessageResult = await _instaApi.SendDirectMessage($"{firstThread.Users.FirstOrDefault()?.Pk}", string.Empty , "one more test");
            //Console.WriteLine(sendMessageResult.Succeeded ? "Message sent" : "Unable to send message");

            
        }
    }
}