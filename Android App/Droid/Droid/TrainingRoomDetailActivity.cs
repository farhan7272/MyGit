
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Droid
{
    [Activity(Label = "TrainingRoomDetailActivity")]
    public class TrainingRoomDetailActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.training_room_detail);

            int roomId = Intent.GetIntExtra("roomId", 0);
            var repo = new TrainingRooms.RoomRepository();
            var room = repo.GetRoom(roomId);

            this.Title = "Room Detail";
            this.FindViewById<TextView>(Resource.Id.txtName).Text = room.Name;
            this.FindViewById<TextView>(Resource.Id.txtLocation).Text = room.Location;
        }
    }
}
