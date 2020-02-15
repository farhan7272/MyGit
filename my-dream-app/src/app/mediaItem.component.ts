import { Component } from '@angular/core';

@Component({
  selector: 'matrix-mediaItem',
  templateUrl: './mediaItem.component.html',
  styleUrls: ['./mediaItem.component.css']
})
export class MediaItemComponent {
  title = 'Media Item!';
  message = 'This is a sample Media Item';
  videoSource = 'https://www.youtube.com/embed/tgbNymZ7vqY';
}