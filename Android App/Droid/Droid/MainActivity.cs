using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using TrainingRooms;

namespace Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : ListActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            this.Title = "Training Rooms";
            var repo = new RoomRepository();
            var rooms = repo.GetRooms();

            var adapter = new ArrayAdapter<TrainingRoom>(this,
                                                         Resource.Layout.room_list_item,Resource.Id.txtRoomItem,
                                                         rooms.ToArray());

            this.ListAdapter = adapter;
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this,
                                    typeof(TrainingRoomDetailActivity));

            var selectedItem = ((ArrayAdapter<TrainingRoom>)ListAdapter).GetItem(position);
            intent.PutExtra("roomId", selectedItem.Id);

            StartActivity(intent);

        }

    }
}

